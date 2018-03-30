using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class BoxScript : MonoBehaviour {

	// Publics
	public Rigidbody2D rb2d;
	public float releaseTime = .15f;
	public Rigidbody2D hook;
	public float maxDrag = 2f;
	public int numPlayerBoxes;
	public GameObject ball;
	public Image myImage;
	EnemyScript enemy;

	// Privates
	private bool isSelected = false;
	//public TrailRenderer trail;
	private Scene scene;



	// Use this for initialization
	void Start () {
	 scene = SceneManager.GetActiveScene ();
	}
	
	// Update is called once per frame
	void Update () {



		if (isSelected) {

			Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

			if (Vector3.Distance (mousePos, hook.position) > maxDrag) {
				rb2d.position = hook.position + ( mousePos - hook.position ).normalized * maxDrag;

			} 
			else {
				rb2d.position = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			}
		}


	}

	void OnMouseDown(){

		Debug.Log ("Mouse Down!");
		isSelected = true;
		rb2d.isKinematic = true;

	}

	void OnMouseUp(){

		Debug.Log ("Mouse UP!");
		isSelected = false;
		rb2d.isKinematic = false;

		StartCoroutine(Release());
		numPlayerBoxes--;

	}

	IEnumerator Release()
	{
		yield return new WaitForSeconds (releaseTime);
		GetComponent<SpringJoint2D> ().enabled = false;
		//trail.enabled = true;


		this.enabled = false;


		yield return new WaitForSeconds (5f);


			
			if (ball != null) {

				Destroy (myImage);
				Destroy (this.gameObject);
				
				ball.SetActive (true);

			}

		else {

			EnemyScript.numEnemies = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

	void OnCollisionEnter2D(Collision2D other )
	{
		if (other.gameObject.tag == "destRock") {

			Destroy (other.gameObject);
		}

	}


}

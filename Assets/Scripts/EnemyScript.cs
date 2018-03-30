using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour {

	public float health = 4f;

	public static int numEnemies = 0;

	private int restartTime = 3;

	// Use this for initialization

	public void setEnemies(int num){
		numEnemies = num;

	}

	void Start () {
		numEnemies++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D otherObj){

		if(otherObj.relativeVelocity.magnitude > health)
		{
			// Destroy OBJ
			Debug.Log(otherObj.relativeVelocity.magnitude);
			Kill();

		}

	}

	void Kill ()
	{
		numEnemies--;


		Destroy (gameObject);
		if (numEnemies <= 0) {
			Debug.Log ("YOU WON!");

			// Start Delay
			StartCoroutine(Delay());

			Scene scene = SceneManager.GetActiveScene ();
			if( scene.name == "Level1-WareHouse")
			// Reload Scene / Move to Next Scene
			SceneManager.LoadScene("Level2-Moon");

			else if(scene.name == "Level2-Moon")
				SceneManager.LoadScene("Level3-Space");
			else if(scene.name == "Level3-Space")
				SceneManager.LoadScene("Level1-WareHouse");

		}

	}

	IEnumerator Delay ()
	{
		yield return new WaitForSeconds (restartTime);

	}


}

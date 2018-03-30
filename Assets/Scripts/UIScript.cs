using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		EnemyScript enemy;

		if (Input.GetKeyDown ("r")) {
			Debug.Log ("R IS DOWN");
			EnemyScript.numEnemies = 0;
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		} 
		else if (Input.GetKeyDown ("1")) {
			// Reload Scene / Move to Next Scene
			EnemyScript.numEnemies = 0;
			SceneManager.LoadScene ("Level1-WareHouse");
		} 
		else if (Input.GetKeyDown ("2")) {
			EnemyScript.numEnemies = 0;
			SceneManager.LoadScene ("Level2-Moon");
		} 
		else if (Input.GetKeyDown ("3")) {
			EnemyScript.numEnemies = 0;
			SceneManager.LoadScene ("Level3-Space");
		}
		else if (Input.GetKeyDown ("0")) {
			EnemyScript.numEnemies = 0;
			SceneManager.LoadScene ("Opening Menu");
		}
		
	}
		

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class MenuScript : MonoBehaviour {
	public Button myButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("enter")) {
			Debug.Log ("Space IS DOWN");
			SceneManager.LoadScene ("Level1-WareHouse");
		} 

	}
	public void enterGame()
	{

		SceneManager.LoadScene ("Level1-WareHouse");
	}

	public void loadThree()
	{

		SceneManager.LoadScene ("Level3-Space");
	}
}

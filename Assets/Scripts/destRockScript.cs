using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destRockScript : MonoBehaviour {

	private BoxScript box;
	private GameObject player;


	// Use this for initialization
	void Start () {

		//box = FindObjectOfType<BoxScript> ();
		player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

}

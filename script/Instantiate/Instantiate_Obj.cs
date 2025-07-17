using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine .UI ;
using System;


public class Instantiate_Obj : MonoBehaviour {

	public GameObject Instantiate_Position;
	public GameObject table;
	//public GameObject obj;

	void Start () {

		this.GetComponent<Button> ().onClick.AddListener (Clickme);

	}




	void Clickme()
	{


		Instantiate (table, Instantiate_Position.transform.position,Quaternion.Euler(270,0,0));

	}
}

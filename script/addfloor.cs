using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine .UI ;
using System;

public class addfloor : MonoBehaviour {

	// Use this for initialization


	public Camera camera1,camera2,camera3,camera4;
	public GameObject plane,Instantiate_Position1,Instantiate_Position2;
	public static float limithigh = 100, limitlow = -60;

	void Start()
	{

		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(OnClick);
	}

	void OnClick()
	{
		limithigh += 218;
		limitlow += 218;
		camera1.transform.position += new Vector3(0, 218, 0);
		camera2.transform.position += new Vector3(0, 218, 0);
		camera3.transform.position += new Vector3(0, 218, 0);
		camera4.transform.position += new Vector3(0, 218, 0);
		Instantiate_Position2.transform.position += new Vector3 (0, 218, 0);
		Instantiate_Position1.transform.position += new Vector3 (0, 218, 0);


	}
}
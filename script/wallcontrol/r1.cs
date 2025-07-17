using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class r1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
		gameObject.transform.Rotate (new Vector3 (0, 90, 0));
    }
}

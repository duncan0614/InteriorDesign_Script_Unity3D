using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class INplane : MonoBehaviour
{

    public GameObject Instantiate_Position2;
    public GameObject plane;
    //public GameObject obj;

    void Start()
    {

        this.GetComponent<Button>().onClick.AddListener(Clickme);

    }




    void Clickme()
    {


        Instantiate(plane, Instantiate_Position2.transform.position,

            Instantiate_Position2.transform.rotation);
    }
}

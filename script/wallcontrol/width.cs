using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine .UI ;

public class width : MonoBehaviour {

    public GameObject cube;
    public Slider slider;
    

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CubeChangeScale()
    {

        cube.transform.localScale = new Vector3(100f, 100f, slider.value * 1000);

    }
}

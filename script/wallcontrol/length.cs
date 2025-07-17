using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class length : MonoBehaviour
{


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

		cube.transform.localScale = new Vector3( 1,  80, slider.value * 10);
		slider.minValue = 1;


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class rotation : MonoBehaviour
{

    public GameObject target;
    public KeyCode up;
    public KeyCode left;
    public KeyCode right;
    public KeyCode down;
    void Start()
    {

    }
     void Update()
    {
        if (Input.GetKeyDown(up))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(down))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(left))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 90, 0);
        if (Input.GetKeyDown(right))
            GetComponent<Transform>().eulerAngles = new Vector3(0, -90, 0);

    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obj;
    public GameObject target;

    private void OnMouseUp()
    {
        obj = gameObject;
        target = obj;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.V))
        {
            Instantiate(target);
            target = null;
        }

    }
}

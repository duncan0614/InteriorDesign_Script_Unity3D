using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mousemass : MonoBehaviour
{
    public float mass;
    public Rigidbody rb;
    void OnMouseUp()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 10000;
    }

    void OnMouseDown()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 1;
    }
}

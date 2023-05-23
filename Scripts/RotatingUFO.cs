using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingUFO : MonoBehaviour
{
    public Rigidbody rb;
    public float rotationSpeed = 20f;

    void Update()
    {
        rb.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
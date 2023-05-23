using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = -0.000004f;
    void Update()
    {
        rb.AddForce(0, 0, speed);
    }
}

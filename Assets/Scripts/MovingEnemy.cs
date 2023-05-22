using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public Rigidbody rb;

    void Update()
    {
        rb.AddForce(0, 0, -0.000004f);
    }
}

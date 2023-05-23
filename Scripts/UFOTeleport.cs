using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOTeleport : MonoBehaviour
{
    public Rigidbody rb;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "UFO")
        {
            Destroy(rb);
        }
    }

    void Update()
    {
        rb.AddForce(0, 0.1f, 0, ForceMode.VelocityChange);

    }
}


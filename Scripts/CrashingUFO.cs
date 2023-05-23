using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashingUFO : MonoBehaviour
{
    public Rigidbody rb;
    public bool destroyed = false;
    public float speed_vertical = 0.00004f;
    public float speed_z = 0.000001f;
    public float speed_x = 0.000001f;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Ground")
        {
            rb.transform.localScale = Vector3.zero;
            destroyed = true;
        }
    }

    void Update()
    {
        if (destroyed == false)
        {
            rb.AddForce(speed_x, speed_vertical, speed_z, ForceMode.VelocityChange);
        }
    }
}

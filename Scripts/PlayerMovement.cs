using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1500f;
    public float maxRotationAngle = 30f;

    public void BoostActivation()
    {
        rb.AddForce(0, 13f, 0, ForceMode.VelocityChange);
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(0.2f, 0, 0, ForceMode.VelocityChange);
            RotateCar(0.5f);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-0.2f, 0, 0, ForceMode.VelocityChange);
            RotateCar(-0.5f);
        }

        if (!Input.GetKey("a") && !Input.GetKey("d"))
        {
            RotateCar(0f);
        }

        if (rb.position.y < -1f)
        {
            rb.AddForce(0, -0.1f, 0, ForceMode.VelocityChange);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void RotateCar(float direction)
    {
        float rotationAngle = maxRotationAngle * direction;
        Quaternion targetRotation = Quaternion.Euler(0f, rotationAngle, 0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
    }
}
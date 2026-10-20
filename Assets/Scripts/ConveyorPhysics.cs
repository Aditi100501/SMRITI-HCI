using UnityEngine;

public class ConveyorPhysics : MonoBehaviour
{
    public float speed = 2.0f;
    public Vector3 direction = Vector3.forward;

    void OnCollisionStay(Collision collision)
    {
        // Checks if the object touching the belt has a Rigidbody
        if (collision.rigidbody != null)
        {
            // Pushes the object in the specified direction
            collision.rigidbody.linearVelocity = transform.TransformDirection(direction) * speed;
        }
    }
}
using UnityEngine;

public class ProductSorter : MonoBehaviour
{
    public Vector3 pushRightDirection = new Vector3(1, 0, 0);
    public Vector3 pushLeftDirection = new Vector3(-1, 0, 0);
    public float pushSpeed = 3f;

    // OnTriggerStay runs continuously while an object is inside the zone
    void OnTriggerStay(Collider other)
    {
        // attachedRigidbody automatically finds the Rigidbody on the parent object
        Rigidbody rb = other.attachedRigidbody;

        if (rb != null)
        {
            if (rb.gameObject.CompareTag("Good"))
            {
                rb.linearVelocity = pushRightDirection * pushSpeed;
            }
            else if (rb.gameObject.CompareTag("Defective"))
            {
                rb.linearVelocity = pushLeftDirection * pushSpeed;
            }
        }
    }
}
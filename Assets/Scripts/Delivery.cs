using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package")
        {
            Debug.Log("Package picked up");
        }

        if(collision.tag == "Customer")
        {
            Debug.Log("Delivered package");
        }
    }
}

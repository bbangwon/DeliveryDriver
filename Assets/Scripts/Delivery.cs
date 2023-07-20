using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    [SerializeField]
    float destroyDelay = 0.5f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
        }

        if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered package");
            hasPackage = false;
        }
    }
}

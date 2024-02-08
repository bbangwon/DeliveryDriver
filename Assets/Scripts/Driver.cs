using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    Vector2 moveDirection;

    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = moveDirection.x * steerSpeed * Time.deltaTime;
        float moveAmount = moveDirection.y * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    void OnMove(InputValue value)
    {
        moveDirection = value.Get<Vector2>();
    }
}

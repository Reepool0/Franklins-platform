using UnityEngine;
using UnityEngine.InputSystem;


public class playerController : MonoBehaviour
{
    [SerializeField]
    float walkSpeed = 10;

    float movementX = 0;

    [SerializeField]
    float jumpForce = 500;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJump(InputValue value)
    {
        rb.AddForce(Vector2.up * jumpForce);
    }
    void OnMove(InputValue value)
    {
      movementX = value.Get<Vector2>().x;

    }
}

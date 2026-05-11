using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public float moveSpeed = 5f;
    Vector2 movingInput;

    void FixedUpdate()
    {
        playerBody.linearVelocity = movingInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        movingInput = context.ReadValue<Vector2>();
    }
}

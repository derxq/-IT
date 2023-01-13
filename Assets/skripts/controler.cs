using UnityEngine;

public class controler : MonoBehaviour
{
    public float speed = 5f;

    public CharacterController CharacterController;

    Vector3 move;

    Vector3 velocity;

    public float gravity = -22f;

    public Transform groundCheck;

    public float groundDistance = 0.4f;

    public LayerMask groundMask;

    bool isGrounded;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        move = transform.right * horizontal + transform.forward * vertical;
        CharacterController.Move(move * speed * Time.deltaTime);
        
        velocity.y += gravity * Time.deltaTime;
        CharacterController.Move(velocity * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
    }
}
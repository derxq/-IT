using UnityEngine;

public class controler : MonoBehaviour
{
    public float speed_Move = 5f;
    public float speed_Run;
    public float speed_Current;
    public CharacterController CharacterController;

    Vector3 move_Direction;

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

        move_Direction = transform.right * horizontal + transform.forward * vertical;
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed_Current = speed_Run;
        }
        else
        {
            speed_Current = speed_Move;
        }

        
        CharacterController.Move(move_Direction * speed_Current * Time.deltaTime);
        
        velocity.y += gravity * Time.deltaTime;
        CharacterController.Move(velocity * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
    }
}
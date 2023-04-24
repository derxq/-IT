using UnityEngine;

public class controler : MonoBehaviour
{
    public int hearth = 5;
    public float speed_Move = 5f;
    public float speed_Run = 10f;
    private float speed_Current = 5f;
    public CharacterController CharacterController;

    Vector3 move_Direction;

    Vector3 velocity;

    public float gravity = -22f;

    public Transform groundCheck;

    public float groundDistance = 0.4f;

    public LayerMask groundMask;

    bool isGrounded;
    float timeStart = 0;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        move_Direction = transform.right * horizontal + transform.forward * vertical;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (timeStart < 5)
                speed_Current = speed_Run;
            else
                speed_Current = speed_Move;

            timeStart += Time.deltaTime;
        }
        else
        {
            timeStart = 0;
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
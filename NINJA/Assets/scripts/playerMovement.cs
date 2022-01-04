using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed=10;
    public CharacterController controller;
    public LayerMask groundMask;
    bool grounded;
    public Transform groundcheck;
    public float groundcheckradius=0.4f;
    public float gravity=-19.6f;
    public float jumpheight=2;
    public Joystick joystick;
    bool input=false;
    Vector3 velocity;
    float x;
    float z;
    void Update()
    {
        grounded=Physics.CheckSphere(groundcheck.position, groundcheckradius, groundMask);
        if (grounded && velocity.y<0){
            velocity.y=-0.4f;
        }
        if (Input.GetButton("Jump")){
            jump();
        }
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            input = true;
        } else{
            input=false;
        }
        if (input == false)
        {
            x = Input.GetAxis("Horizontal") + joystick.Horizontal;
            z = Input.GetAxis("Vertical") + joystick.Vertical;
        }
        else
        {
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");
        }
        Vector3 direction=transform.forward*z + transform.right*x;
        controller.Move(direction * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    public void jump(){
        if (grounded){
            velocity.y = Mathf.Sqrt(jumpheight * gravity * -2);
        }
    }
}

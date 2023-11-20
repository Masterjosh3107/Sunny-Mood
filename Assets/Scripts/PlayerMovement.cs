using Unity.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float horizontalMove = 0f;
    public float speed = 40;
    bool jump = false;
    bool crouch = false;

    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

       if (Input.GetButtonDown("Jump")){
        jump = true;
       }

       if (Input.GetButtonDown("Crouch")){
        crouch = true;
       } else if (Input.GetButtonUp("Crouch")){
        crouch = false;
       }
    }

    void FixedUpdate(){
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}

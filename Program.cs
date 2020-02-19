using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    [AddComponentMenu("Game Systems/RPG/PLayer/Movement,look")]
    [RequireComponent(typeof(CharacterController))]
    public class Playermovement : MonoBehaviour
    {
        [Header("physics")]
        public float gravity = 20f;
        public CharacterController controller;
        [Header("Movement Variables")]
        public float speed = 5f;
        public float jumpspeed = 8f;
        public float sprintspeed = 10f;
        public float crouchspeed = 2.5f;
        // might be the float to sprint a character? Must try and bind shift

        public Vector3 moveDirection;

        void Start()
        {
            //Grabs character controller aka attaching to object
            controller = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (controller.isGrounded)
            {
                moveDirection = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
                moveDirection *= speed;
                if (Input.GetButton("Jump"))
                {
                    moveDirection.y = jumpspeed;
                }
            }
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                speed = sprintspeed;
            }
            else
            {
                speed = speed;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed = 5f;
            }
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                speed = crouchspeed;
            }
            if (Input.GetKeyUp(KeyCode.LeftControl))
            {
                speed = 5f;
            }
        }
    }
}




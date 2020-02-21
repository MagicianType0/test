using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Playerhandle : Character
{
    #region Variables
    [Header("Physics")]
    public CharacterController controller;
    public float gravity = 20f;
    public Vector3 moveDirection;
    [Header("levelData")]
    public int level = 0;
    public float currentExp, neededExp, maxExp;
    #endregion

    #region behaviour
    void Start()
    {
        controller = this.gameObject.GetComponent<CharacterController>();
    }
    public override void Movement()
    {
        base.Movement();
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
    }
    #endregion
}

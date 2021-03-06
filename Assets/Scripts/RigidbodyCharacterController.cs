﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class RigidbodyCharacterController : MonoBehaviour
{

    [SerializeField]
    private float speed = 10;
    
    [SerializeField]
    private float jumpPower = 2;

    [SerializeField]
    private float forwardSpeed = 1;
    
    [SerializeField]
    private float speedMult = 0.01F;

    private Vector2 input;
    private new Rigidbody rigidbody;

    public int JumpCount = 0;
    public int MaxJumps = 1;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    //public Animator animator;

    private void Start()
    {

        rigidbody = GetComponent<Rigidbody>();
        //collider = GetComponent<Collider>();
        JumpCount = MaxJumps;

    }

    private void FixedUpdate()
    {

        var inputDirection = new Vector3(input.x, 0, forwardSpeed);

        transform.Translate(inputDirection * speed);

        forwardSpeed = forwardSpeed + speedMult;

    }

    private void Update()
    {

        input.x = Input.GetAxisRaw("Horizontal");

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////JUMP ZONE
        if (Input.GetButtonDown("Jump"))
        {
            if (JumpCount > 0)
            {
                //rigidbody.AddForce(0, jumpPower, 0, ForceMode.Impulse);
                rigidbody.velocity = transform.up * 6;
                JumpCount -= 1;
            }
            //rigidbody.velocity = transform.up * 10;
        }

        if (rigidbody.velocity.y < 0)
        {
            rigidbody.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rigidbody.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rigidbody.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////JUMP ZONE

        //if (Input.GetKey(KeyCode.LeftControl))
        //{

        //    animator.SetBool("IsSliding", true);

        //}
        //else
        //{

        //    animator.SetBool("IsSliding", false);

        //}

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

            //Debug.Log("GROUND");
            JumpCount = MaxJumps;

        }
    }


}

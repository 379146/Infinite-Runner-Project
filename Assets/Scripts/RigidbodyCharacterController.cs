﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class RigidbodyCharacterController : MonoBehaviour
{

    [SerializeField]
    private float speed = 10;

    [SerializeField]
    private float forwardSpeed = 1;
    
    [SerializeField]
    private float speedMult = 0.01F;

    //[SerializeField]
    //private float maxSpeed = 8;

    //[SerializeField]
    //private PhysicMaterial stoppingPhysicsMaterial, movingPhysicsMaterial;

    //[SerializeField]
    //[Tooltip("0 = no turning, 1 = Instant turning")]
    //[Range(0, 1)]
    //private float turnSpeed = 0.1f;

    private new Rigidbody rigidbody;
    private Vector2 input;
    private new Collider collider;

    private void Start()
    {

        rigidbody = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();

    }

    private void FixedUpdate()
    {

        //var inputDirection = new Vector3(input.x, 0, input.y);
        var inputDirection = new Vector3(input.x, 0, forwardSpeed);

        transform.Translate(inputDirection * speed);

        forwardSpeed = forwardSpeed + speedMult;

        //Vector3 cameraFlattenedForward = Camera.main.transform.forward;
        //cameraFlattenedForward.y = 0;
        //Quaternion cameraRotation = Quaternion.LookRotation(cameraFlattenedForward);

        //Vector3 cameraRelativeInputDirection = cameraRotation * inputDirection;

        //if (inputDirection.magnitude > 0)
        //{

        //    collider.material = movingPhysicsMaterial;

        // }
        //else
        //{
        //    collider.material = stoppingPhysicsMaterial;
        //}
        //if (rigidbody.velocity.magnitude < maxSpeed)
        //{
        
            //rigidbody.AddForce(inputDirection * accelerationForce, ForceMode.Acceleration);

        //    transform.Translate(inputDirection * accelerationForce);

        //}

        //if (cameraRelativeInputDirection.magnitude > 0)
        //{

        //    var targetRotation = Quaternion.LookRotation(cameraRelativeInputDirection);
        //    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnSpeed);

        //}

    }

    private void Update()
    {

        input.x = Input.GetAxisRaw("Horizontal");
        //input.y = Input.GetAxisRaw("Vertical");
    
    }

}

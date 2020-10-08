using System.Collections;
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

    private Vector2 input;

    private void FixedUpdate()
    {

        var inputDirection = new Vector3(input.x, 0, forwardSpeed);

        transform.Translate(inputDirection * speed);

        forwardSpeed = forwardSpeed + speedMult;

    }

    private void Update()
    {

        input.x = Input.GetAxisRaw("Horizontal");
    
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public float acceleration = 30.0f;
    public float turn = 3.5f;

    float accelerationInput = 0;
    float steeringInput = 0;
    float rotationAngle = 0;

    Rigidbody2D boatRigidbody2D;

    void Awake()
    {
        boatRigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        ApplyMotorForce();
        ApplySteeringForce();
    }

    void ApplyMotorForce()
    {
        Vector2 motorForceVector = transform.up * accelerationInput * acceleration;

        boatRigidbody2D.AddForce(motorForceVector, ForceMode2D.Force);
    }

    void ApplySteeringForce() 
    {
        rotationAngle -= steeringInput * turn;

        boatRigidbody2D.MoveRotation(rotationAngle);
    }

    public void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }
}

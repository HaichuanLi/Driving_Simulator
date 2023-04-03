using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuivreRoute : MonoBehaviour
{
    public GameObject PNJ;
    [SerializeField] WheelCollider FrontRightWheel;
    [SerializeField] WheelCollider FrontLeftWheel;
    [SerializeField] WheelCollider RearRightWheel;
    [SerializeField] WheelCollider RearLeftWheel;


    public float acceleration = 100f;
    public float breakingForce = 60f;
    public float maxTurnAngle = 45f;


    private float currentAcceleration = 0f;
    private float currentBrakeForce = 0f;
    private float currentTurnAngle = 0f;

    private void FixedUpdate()
    {
        currentAcceleration = acceleration * Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
            currentBrakeForce = breakingForce;


        else
            currentBrakeForce = 0f;



        FrontRightWheel.motorTorque = currentAcceleration;
        FrontLeftWheel.motorTorque = currentAcceleration;


        FrontRightWheel.brakeTorque = currentBrakeForce;
        FrontLeftWheel.brakeTorque = currentBrakeForce;
        RearRightWheel.brakeTorque = currentBrakeForce;
        RearLeftWheel.brakeTorque = currentBrakeForce;

        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        FrontLeftWheel.steerAngle = currentTurnAngle;
        FrontRightWheel.steerAngle = currentTurnAngle;

    }

}

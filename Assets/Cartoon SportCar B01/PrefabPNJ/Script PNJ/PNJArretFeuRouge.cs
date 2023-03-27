using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJArretFeuRouge : MonoBehaviour
{
    [SerializeField] WheelCollider FrontRightWheel;
    [SerializeField] WheelCollider FrontLeftWheel;
    [SerializeField] WheelCollider RearRightWheel;
    [SerializeField] WheelCollider RearLeftWheel;

    public GameObject lumiere;
    public GameObject activateur;
    public Rigidbody voiture;

    public float acceleration = 100f;
    public float breakingForce = 60f;
    public float maxTurnAngle = 45f;


    private float currentAcceleration = 0f;
    private float currentBrakeForce = 0f;
    private float currentTurnAngle = 0f;

    private void FixedUpdate()
    {
        currentAcceleration = acceleration;


        FrontRightWheel.motorTorque = currentAcceleration;
        FrontLeftWheel.motorTorque = currentAcceleration;


        FrontRightWheel.brakeTorque = currentBrakeForce;
        FrontLeftWheel.brakeTorque = currentBrakeForce;
        RearRightWheel.brakeTorque = currentBrakeForce;
        RearLeftWheel.brakeTorque = currentBrakeForce;


        FrontLeftWheel.steerAngle = currentTurnAngle;
        FrontRightWheel.steerAngle = currentTurnAngle;


    }
    private void OnTriggerStay(Collider activateur)
    {
        if (lumiere.GetComponent<ChangerLumiere>().rouge.active)
        {

            arreterVoiture();



        }
        else
        {
            accelererVoiture();
        }
            


    }
    public void arreterVoiture()
    {
        currentBrakeForce = breakingForce;
        voiture.drag = 3;
    }
    public void accelererVoiture()
    {
        currentBrakeForce = 0f;
        voiture.drag = 0;
    }


}

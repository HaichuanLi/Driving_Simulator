using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Menu : MonoBehaviour
{
    [SerializeField] WheelCollider FrontRightWheel;
    [SerializeField] WheelCollider FrontLeftWheel;

    private float currentAcceleration = 100f;



    private void FixedUpdate()
    {

        FrontRightWheel.motorTorque = currentAcceleration;
        FrontLeftWheel.motorTorque = currentAcceleration;


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJBouger : MonoBehaviour
{
    public GameObject pnj;
    [SerializeField] WheelCollider FrontRightWheel;
    [SerializeField] WheelCollider FrontLeftWheel;
    [SerializeField] WheelCollider RearRightWheel;
    [SerializeField] WheelCollider RearLeftWheel;
    public Transform circuit;
    private List<Transform> nodes;
    private int currentNode = 0;

    

    public GameObject lumiere;
    public GameObject activateur;
    public Rigidbody voiture;
    

   

    
    public float acceleration = 100f;
    public float breakingForce = 60f;
    public float maxTurnAngle = 30f;
    public float vitesseMax = 35f;


    private float currentAcceleration = 0f;
    private float currentBrakeForce = 0f;
    private float currentTurnAngle = 0f;

    private void Start()
    {
        Transform[] pathTransforms = circuit.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i =0; i < pathTransforms.Length; i++)
        {
            if (pathTransforms[i] != circuit.transform)
            {
                nodes.Add(pathTransforms[i]);
            }
        }

    }
    private void FixedUpdate()
    {
        if (pnj.GetComponent<DeterminerVitesse>().vitesse > vitesseMax)
        {
        currentAcceleration = 0;

        }
        else
        {
            currentAcceleration = acceleration;
        }


        


        FrontRightWheel.brakeTorque = currentBrakeForce;
        FrontLeftWheel.brakeTorque = currentBrakeForce;
        RearRightWheel.brakeTorque = currentBrakeForce;
        RearLeftWheel.brakeTorque = currentBrakeForce;


        FrontLeftWheel.steerAngle = currentTurnAngle;
        FrontRightWheel.steerAngle = currentTurnAngle;


        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxTurnAngle;
        FrontLeftWheel.steerAngle = newSteer;
        FrontRightWheel.steerAngle = newSteer;

        FrontRightWheel.motorTorque = currentAcceleration;
        FrontLeftWheel.motorTorque = currentAcceleration;
        CalculerDistanceWaypoint();

       
        
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
        Debug.Log("arret");
        currentBrakeForce = breakingForce;
        voiture.drag = 3;
    }
    public void accelererVoiture()
    {
        Debug.Log("acceleration");
        currentBrakeForce = 0f;
        voiture.drag = 0;
    }

    private void CalculerDistanceWaypoint()
    {
        if (Vector3.Distance(pnj.transform.position, nodes[currentNode].position) < 0.1f)
        {
            if (currentNode == nodes.Count - 1)
            {
                pnj.SetActive(false);
            }
            else
            {
                currentNode++;
            }
        }
    }


}

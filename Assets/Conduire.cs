using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conduire : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward*speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(-Vector3.forward*speed);
        }
    }
}

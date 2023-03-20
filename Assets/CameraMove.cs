using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward*Time.deltaTime*10);
        if (this.transform.position.z > 200)
        {
            this.transform.position.Set(11 , 1, 2);
        }

       

    }
}

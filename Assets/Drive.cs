using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Rotate(0, 2, 0);

        }
    }
    
}

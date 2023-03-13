using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject testBox;


    private void OnTriggerEnter(Collider other)
    {
        
        
            testBox.SetActive(true);
        
    }

    private void OnTriggerExit(Collider other)
    {
        testBox.SetActive(false);
    }
}

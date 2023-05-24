using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetecterVoitureDevant : MonoBehaviour
{
    public GameObject PNJ;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PrefabPNJ")
        {
            PNJ.GetComponent<BougerPnjNiv5>().procheDeVoiture = true;

        }
        
        
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "PrefabPNJ")
        {
            PNJ.GetComponent<BougerPnjNiv5>().procheDeVoiture = false;

        }

    }
}

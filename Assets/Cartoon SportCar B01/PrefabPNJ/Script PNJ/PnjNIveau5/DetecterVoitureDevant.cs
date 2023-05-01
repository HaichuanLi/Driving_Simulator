using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecterVoitureDevant : MonoBehaviour
{
    public GameObject DetecteurZoneSecuritaire;
    public GameObject PNJ;
    // Start is called before the first frame update
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

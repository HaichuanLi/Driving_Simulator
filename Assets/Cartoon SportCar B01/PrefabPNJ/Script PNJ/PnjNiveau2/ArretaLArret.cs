using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArretaLArret : MonoBehaviour
{

    public GameObject pnj;
    public float tempsArret = 0f;
    private bool arret = false;
    

  
    public void Update()
    {
        
        if (arret == true)
        {
           
            tempsArret += Time.deltaTime;
        }
        
         if (tempsArret >= 1.5f)
        {
            pnj.GetComponent<PNJBougerNiveau2>().accelererVoiture();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        arret = true;
        pnj.GetComponent<PNJBougerNiveau2>().arreterVoiture();
       
        

        
    }
}

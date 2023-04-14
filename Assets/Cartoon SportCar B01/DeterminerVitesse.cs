using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeterminerVitesse : MonoBehaviour
{
    public float vitesse;


    void Start()
    {
        StartCoroutine(CalcVitesse());
        
    }

    IEnumerator CalcVitesse()
    {
        bool bouge = true;
        while (bouge)
        {
            Vector3 posPrecedente = transform.position;

            yield return new WaitForFixedUpdate();

            vitesse=Mathf.RoundToInt((Vector3.Distance(transform.position, posPrecedente)/Time.fixedDeltaTime)*10)-10;
            if (vitesse < 0)
            {
                vitesse = 0;
            }

        }
    }

    
}

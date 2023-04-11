using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DetecteurArret1N1 : MonoBehaviour
{
    public GameObject joueur;
    private float tempsArret = 0f;
    public TextMeshProUGUI messageJoueur;
    public float tempsRecommencer = 0f;
    private int arret=0;

    // Update is called once per frame

    private void Update()
    {
        if (arret == 1)
        { 
            
            if (tempsRecommencer < 3)
            {
                messageJoueur.text = "Vous n'avez pas effetué un arrêt complet! Veuillez réessayer.";
                tempsRecommencer+=Time.deltaTime;
               
            }
            else 
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (arret == 2)
        {
            messageJoueur.text = "Assurer-vous de toujours respecter la limite de vitesse.";
        }
    }
    public void OnTriggerStay(Collider other)
    {

        if (joueur.GetComponent<DeterminerVitesse>().vitesse == 0)
        {
            tempsArret += Time.deltaTime;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (tempsArret < 1)
        {
            arret = 1;
           
        }
        else
            arret = 2;
    }
}

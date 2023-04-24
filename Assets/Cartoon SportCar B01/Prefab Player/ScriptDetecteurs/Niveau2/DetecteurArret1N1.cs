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
    private int arret = 0;


    private void Update()
    {
        if (arret == 1)
        {

            if (tempsRecommencer < 3)
            {
                messageJoueur.text = "Vous n'avez pas effetué un arrêt complet d'une seconde! Veuillez réessayer.";
                tempsRecommencer += Time.deltaTime;

            }
            else
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {

            if (joueur.GetComponent<DeterminerVitesse>().vitesse == 0)
            {
                tempsArret += Time.deltaTime;
            }

        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {

            if (tempsArret < 1)
            {
                arret = 1;

            }
            
        }


    }
}

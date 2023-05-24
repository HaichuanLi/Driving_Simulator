using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/*
 * Script qui d�termine si le joueur effectue un arr�t complet.
 */
public class DetecteurArret1N2 : MonoBehaviour
{
    public GameObject joueur;
    private float tempsArret = 0f;
    public TextMeshProUGUI messageJoueur;
    public float tempsRecommencer = 0f;
    private int arret = 0;
    public GameObject detecteurMessage1;



    private void Update()
    {
        if (arret == 1)
        {

            if (tempsRecommencer < 3)
            {
                messageJoueur.text = "Vous n'avez pas effetu� un arr�t complet d'une seconde! Veuillez r�essayer.";
                tempsRecommencer += Time.deltaTime;

            }
            else
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {

            detecteurMessage1.GetComponent<Detecteur1>().enabled = false;

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
            else
                messageJoueur.text = "Assurez-vous de respecter la limite de vitesse.";
        }


    }
}

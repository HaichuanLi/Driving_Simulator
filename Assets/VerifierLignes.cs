using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VerifierLignes : MonoBehaviour
{
    public GameObject joueur;
    public TextMeshProUGUI messageJoueur;
    private float tempsRecommencer = 0f;
    private float tempsHorsZone= 0f;
    private bool avertissement = false;
    private bool recommencer = false;
    private bool debutCompteur = false;

       void Update() {

        if (avertissement == true)
        {
            messageJoueur.text = "Faites attention, restez dans vos lignes!";
        }

        if (recommencer == true)
        {
            messageJoueur.text = "Vous êtes hors de votre marge de manoeuvre encore une fois ;(";
            if (tempsRecommencer < 3)
            {

                tempsRecommencer += Time.deltaTime;

            }
            else if (tempsRecommencer > 3)

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        Debug.Log(tempsHorsZone);
        if (debutCompteur) {
            if (tempsHorsZone > 1 && tempsHorsZone < 2) {
                    messageJoueur.text = "3";
                }
            else if (tempsHorsZone > 2 && tempsHorsZone < 3)
            {
                messageJoueur.text = "2";
            } else if (tempsHorsZone > 3 && tempsHorsZone < 4)
            {
                messageJoueur.text = "1";
            } else if (tempsHorsZone > 4)
            {
               recommencer= true;
            }
            tempsHorsZone += Time.deltaTime; 
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (!avertissement)
            {
                avertissement = true;
                debutCompteur = true;
            }
            else
            {
                recommencer = true;

            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            tempsHorsZone = 0;
            debutCompteur= false;
        }
    }
}


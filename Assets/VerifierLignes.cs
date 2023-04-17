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
    private bool avertissement = false;
    private bool recommencer = false;

       void Update()
    {
        Debug.Log(avertissement);
        if (avertissement == true)
        {
            messageJoueur.text = "Faites attention, restez dans vos lignes!";
        }

        if (recommencer == true)
        {
            messageJoueur.text = "Vous êtes hors de votre marge de manoeuvre encore une fois";
            if (tempsRecommencer < 3)
            {

                tempsRecommencer += Time.deltaTime;

            }
            else if (tempsRecommencer > 3)

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (!avertissement)
            {
                avertissement = true;

            }
            else
            {
                recommencer = true;

            }
        }


    }
}


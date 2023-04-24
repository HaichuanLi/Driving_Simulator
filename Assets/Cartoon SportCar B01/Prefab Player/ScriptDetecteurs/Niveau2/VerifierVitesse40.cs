using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class VerifierVitesse40 : MonoBehaviour
{
    public GameObject joueur;
    public GameObject detecteur1;
    public TextMeshProUGUI messageJoueur;
    private float tempsRecommencer = 0f;
    private bool avertissement = false;
    private bool recommencer = false;






    void Update()
    {
        if (avertissement == true)
        {
            messageJoueur.text = "Faites attention à votre vitesse!";
        }

        if (recommencer == true)
        {
            messageJoueur.text = "Vous etes allé trop vite. Veuillez réessayer.";
            if (tempsRecommencer < 3)
            {



                tempsRecommencer += Time.deltaTime;



            }
            else if (tempsRecommencer > 3)



                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            detecteur1.GetComponent<DetecteurArret1N2>().enabled = false;
        }




    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (joueur.GetComponent<DeterminerVitesse>().vitesse > 40 && joueur.GetComponent<DeterminerVitesse>().vitesse < 45)
            {
                avertissement = true;



            }
            else
                avertissement = false;
            if (joueur.GetComponent<DeterminerVitesse>().vitesse > 45)
            {
                recommencer = true;



            }
        }

    }
    
}
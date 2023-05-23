using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/*
 * Script qui d�termine si le joueur s'arr�te quand l'autobus engage son panneau d'arr�t.
 */
public class DetecteurArretAutobus : MonoBehaviour
{
    public GameObject joueur;
    public GameObject bus;
   
    public TextMeshProUGUI messageJoueur;
    public float tempsRecommencer = 0f;
    private int arret = 0;
    private float tempsArretAlloue = 0f;
    public bool dansZone = false;
    // Start is called before the first frame update
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
        else if (arret == 2)
        {
            messageJoueur.text = "Merci de faire attention aux enfants. Continuez tout droit.";
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        dansZone= true;
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if(bus.GetComponent<BusControl>().ouvert == true)
            {
                arret = 1;
            }

            else 
                arret = 2;
        }


    }
}
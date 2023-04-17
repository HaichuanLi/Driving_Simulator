using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DetecteurArretAutobus : MonoBehaviour
{
    public GameObject joueur;
    public GameObject bus;
    private float tempsArret = 0f;
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
                messageJoueur.text = "Vous n'avez pas effetué un arrêt complet d'une seconde! Veuillez réessayer.";
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

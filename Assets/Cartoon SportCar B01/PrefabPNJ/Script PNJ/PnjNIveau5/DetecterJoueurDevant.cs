using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class DetecterJoueurDevant : MonoBehaviour
{
    public TextMeshProUGUI messageJoueur;
    private float tempsRecommencer = 0f;
    private bool recommencer = false;


    // Update is called once per frame
    void Update()
    {
        if (recommencer)
        {
            if (tempsRecommencer < 3f)
            {
                messageJoueur.text = "Vous n'avez pas effectué la maneuvre à un moment sécuritaire! Veuillez réessayer.";
                tempsRecommencer += Time.deltaTime;
            } 
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        
    }
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            recommencer = true;

        }


    }

    
}

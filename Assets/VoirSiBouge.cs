using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VoirSiBouge : MonoBehaviour
{
    public GameObject joueur;
    public TextMeshProUGUI messageJoueur;
    private bool sortie = false;
    private float timer=0;
    void Update()
    {
        if (sortie == true&& timer <3)
        {
            messageJoueur.text = "Appuyer sur espace pour freiner.";
            timer+= Time.deltaTime;
        }
        else if (timer>3 && timer<5){
            messageJoueur.text="Rester dans la voie!";
        }
        
          }

    private void OnTriggerExit(Collider other)
    {
        sortie = true;


    }
  }

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

    void Update()
    {
        if (sortie == true)
        {
            messageJoueur.text = "Appuyer sur espace pour freiner ;)";
        }
          }

    private void OnTriggerExit(Collider other)
    {
        sortie = true;


    }
  }

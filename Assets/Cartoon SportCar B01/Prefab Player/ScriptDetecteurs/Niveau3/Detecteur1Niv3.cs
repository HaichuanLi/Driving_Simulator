using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Detecteur1Niv3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI messageJoueur;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            messageJoueur.text = "Portez attention à l'autobus.";
        }


    }


}


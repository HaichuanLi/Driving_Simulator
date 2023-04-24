using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangerMessageJoueur : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI messageJoueur;
    public string message;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            messageJoueur.text = message;

        }


    }


}


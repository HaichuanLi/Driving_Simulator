using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Message1Niv3 : MonoBehaviour
{
    public TextMeshProUGUI messageJoueur;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            messageJoueur.text = "Continuez tout droit.";
        }


    }
}

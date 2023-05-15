using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * Script qui change le message affich� au joueur lorsqu'il arrive au d�tecteur.
 */
public class Detecteur1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI messageJoueur;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            messageJoueur.text = "Assurez-vous de vous arr�ter compl�tement derri�re la ligne d'arr�t pour au moins 1 seconde.";
        }


    }


}
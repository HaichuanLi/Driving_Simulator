using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * Script qui change le message affiché au joueur lorsqu'il arrive au détecteur.
 */
public class Detecteur1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI messageJoueur;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            messageJoueur.text = "Assurez-vous de vous arrêter complètement derrière la ligne d'arrêt pour au moins 1 seconde.";
        }


    }


}
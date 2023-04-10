using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Detecteur1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI messageJoueur;



    public void OnTriggerEnter(Collider other)
    {
        messageJoueur.text = "Assurez-vous de vous arrêter complètement derrière la ligne d'arrêt pour au moins 1 seconde.";
    }


}
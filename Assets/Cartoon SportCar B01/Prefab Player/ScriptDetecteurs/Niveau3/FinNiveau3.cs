using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
/*
 * Script qui passe au niveau suivant lorsque le joueur termine celui-ci.
 */
public class FinNiveau3 : MonoBehaviour
{
    private bool fin = false;
    public GameObject joueur;
    public TextMeshProUGUI messageJoueur;
    private float decompte = 0;

    public void Update()
    {
        if (fin)
        {
            if (decompte < 3)
            {
                decompte += Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene("Niveau4");

            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            messageJoueur.text = "Félicitation! Passage au niveau 4.";
            joueur.GetComponent<WheelController>().arreterVoiture();
            fin = true;

        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FInNiv2 : MonoBehaviour
{
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Niveau3");


        }


    }
}

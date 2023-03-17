using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowText : MonoBehaviour {

    public GameObject joueur;
    public TMP_Text canvasText;


    // Start is called before the first frame update
    void Start()
    {
        canvasText.text =  joueur.GetComponent<DeterminerVitesse>().vitesse.ToString();
   
    }

    // Update is called once per frame
    void Update()
    {
        canvasText.text = joueur.GetComponent<DeterminerVitesse>().vitesse.ToString();
    }
}

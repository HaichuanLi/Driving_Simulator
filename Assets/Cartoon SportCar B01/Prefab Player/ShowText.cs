using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour {

    public GameObject joueur;
    private Text vitesse;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(joueur.GetComponent<DeterminerVitesse>().vitesse.ToString());
        vitesse.text = joueur.GetComponent<DeterminerVitesse>().vitesse.ToString();
   
    }

    // Update is called once per frame
    void Update()
    {
        vitesse.text =  joueur.GetComponent<DeterminerVitesse>().vitesse.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour {

    public GameObject joueur;
    public string textValue;
    public Text textElemenbt;


    // Start is called before the first frame update
    void Start()
    {
        textValue =  joueur.GetComponent<DeterminerVitesse>().vitesse.ToString();
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

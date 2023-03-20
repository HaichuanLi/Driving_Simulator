using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerLumiere : MonoBehaviour
{
    public GameObject rouge;
    public GameObject jaune;
    public GameObject vert;
    public float tempspartiel;
    public float temps;
     
    // Start is called before the first frame update
    void Start()
    {
        temps = 1;
        rouge.SetActive(false);
        jaune.SetActive(false);
        vert.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
               temps += Time.deltaTime;
        Debug.Log(temps);

        tempspartiel = temps;
        if ((int)tempspartiel%20 == 0){
            rouge.SetActive(false);
            vert.SetActive(true);
            temps = 1;
        }
        
        if ((int)tempspartiel == 8){
                vert.SetActive(false);
                jaune.SetActive(true);
            } else if ((int)tempspartiel == 10){
                rouge.SetActive(true);
                jaune.SetActive(false);
            }
    }
}

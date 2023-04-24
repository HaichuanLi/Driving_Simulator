using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CahngerLumiereEnFonction : MonoBehaviour
{
    public GameObject lumiereMaitresse;
    public GameObject rouge;    
    public GameObject jaune;
    public GameObject vert;
    public bool cadenasRouge = false;

    // Start is called before the first frame update
    void Start()
    {
        rouge.SetActive(true);
        jaune.SetActive(false);
        vert.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(lumiereMaitresse.rouge.active = true && !cadenasRouge) {
            vert.SetActive(true);
            rouge.SetActive(false);
            cadenasRouge = true;
        } 
        if ((int)lumiereMaitresse.tempspartiel % 18 == 0)
        {
            jaune.SetActive(false);
            vert.SetActive(false);
        }
        if (lumiereMaitresse.vert.active = true)
        {
            rouge.SetActive(true);
            jaune.SetActive(false);
            cadenasRouge = false;
        }
    }
}

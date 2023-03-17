using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerLumiere : MonoBehaviour
{
    public GameObject rouge;
    public GameObject jaune;
    public GameObject vert;


    // Start is called before the first frame update
    void Start()
    {
       
        rouge.SetActive(true);
        jaune.SetActive(false);
        vert.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

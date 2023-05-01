using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerLumiereEnFonction : MonoBehaviour
{
    public GameObject rouge;
    public GameObject jaune;
    public GameObject vert;
    public GameObject LumiereMaitresse;
    public GameObject rougeMaitre;
    public GameObject vertMaitre;
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
        if (rougeMaitre == true && !cadenasRouge)
        {
            vert.SetActive(true);
            rouge.SetActive(false);
            cadenasRouge = true;
        }
        if ((int)LumiereMaitresse.GetComponent<ChangerLumiere>().Temps % 18 == 0)
        {
            jaune.SetActive(false);
            vert.SetActive(false);
        }
        if (vertMaitre == true)
        {
            rouge.SetActive(true);
            jaune.SetActive(false);
            cadenasRouge = false;
        }
    }
}
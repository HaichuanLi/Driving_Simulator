using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusControl : MonoBehaviour
{


    public GameObject detecteurArretBus;
    public GameObject bus;
    public Animator StopSign1;
    public Animator StopSign3;
    private int cpt = 0;
    public bool ouvert;
    private float tempsFermer = 0f;
    private bool avancer = false;
    public float OpenCloseSpeed;



    private void Start()
    {
        Open();
        
    }

    private void FixedUpdate()
    {
        if (detecteurArretBus.GetComponent<DetecteurArretAutobus>().dansZone == true)
        {
            tempsFermer += Time.deltaTime;
        }
        if (tempsFermer > 5f && cpt==0)
        {
            cpt++;
            Close();
            avancer = true;
        }
        if (avancer == true)
        {
            bus.GetComponent<BougerBus>().enabled = true;


        }
    }

    public void Open()
    {
        ouvert = true;
        StopSign1.SetTrigger("Open");
        StopSign3.SetTrigger("Open");
    }
    public void Close()
    {
        ouvert = false;
        StopSign1.SetTrigger("Close");
        StopSign3.SetTrigger("Close");
    }




}

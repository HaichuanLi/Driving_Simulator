using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusControl : MonoBehaviour
{

    /// <summary>
    /// This is an example script for controlling the doors and signs on the bus. 
    /// You may wish to create a more specific implementation consistent with your game.
    /// </summary>

    public Animator Door1;
    public Animator Door2;
    public Animator StopSign1;
    public Animator StopSign3;
    private int cpt = 0;
    public bool ouvert;

    public float OpenCloseSpeed;



    private void Start()
    {
        Open();
        
    }

    private void Update()
    {
        if (Time.realtimeSinceStartup > 5f && cpt==0)
        {
            cpt++;
            Close();
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

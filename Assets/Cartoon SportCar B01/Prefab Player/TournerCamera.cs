using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *Classe qui tourne la caméra du joueur 
 */
public class TournerCamera : MonoBehaviour
{
    public Transform joueur;
    
    void Update()
    {
        var playerAngle = joueur.forward;
        var camAngle = transform.forward;
        playerAngle.y = 0;
        camAngle.y = 0;
        var horizDiffAngle = Vector3.Angle(playerAngle, camAngle);
        print(horizDiffAngle);
        if (Input.GetKeyDown(KeyCode.J))
        {
            this.transform.Rotate(Vector3.up, -1, Space.Self);
        }
        else if ((int) horizDiffAngle != 0)
        {
            this.transform.Rotate(Vector3.up, 1, Space.Self);
        }
        

    }
}

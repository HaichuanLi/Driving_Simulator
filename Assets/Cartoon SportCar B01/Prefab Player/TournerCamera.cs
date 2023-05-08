using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetKey(KeyCode.J)&& (int) horizDiffAngle<=75)
        {
            this.transform.Rotate(Vector3.up, -1, Space.Self);
        }
        else if ((int) horizDiffAngle != 0)
        {
            this.transform.Rotate(Vector3.up, 1, Space.Self);
        }
        

    }
}

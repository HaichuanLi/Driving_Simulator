

    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArreLumiere : MonoBehaviour
{
    private int compteur = 0;
    private bool stop = false, toucheTrigger1 = false, toucheTrigger2 = false, arretconfirme = false;
    private float posimage1x, posimage1z, posimage2x, posimage2z;
    public float speed;
    public GameObject lumiere;
    // Start is called before the first frame update
    void Start()
    {
        posimage1x = transform.position.x;
        posimage1z = transform.position.z;

        //Calcul vitesse
        StartCoroutine(CalcSpeed());

    }

    IEnumerator CalcSpeed()
    {
        bool isPlaying = true;
        while (isPlaying)
        {
            Vector3 prevPos = transform.position;
            yield return new WaitForFixedUpdate();
            speed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Trigger1") && !toucheTrigger1)
        {
            toucheTrigger1 = true;
            compteur++;
            Debug.Log("I");
        }
        else if (other.name.Equals("Trigger2") && !toucheTrigger2)
        {
            toucheTrigger2 = true;
            compteur++;
            Debug.Log("S");
        }
    }
    // Update is called once per frame
    void Update()
    {
        posimage2x = transform.position.x;
        posimage2z = transform.position.z;
        if (compteur % 2 == 1)
        {
            if (speed == 0)
            {
                arretconfirme = true;
            }
            if (lumiere.GetComponent<ChangerLumiere>().rouge.active && arretconfirme)
            {
                Debug.Log("Bien vu!");
                stop = true;
                toucheTrigger1 = false;
                toucheTrigger2 = false;
                arretconfirme= false;
            } else if ((lumiere.GetComponent<ChangerLumiere>().vert.active && arretconfirme)||(lumiere.GetComponent<ChangerLumiere>().rouge.active && !arretconfirme))
            {
                Debug.Log("Tu tripppp!");
            } 
        }
        posimage1x = posimage2x;
        posimage1z = posimage2z;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Scripts : MonoBehaviour
{
    // Start is called before the first frame update
   

    public void StartGame()
    {
        Debug.Log("qsadf");
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
           Debug.Log("qsadf");
        Application.Quit();
    }
}

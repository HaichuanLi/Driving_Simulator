using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Scripts : MonoBehaviour
{

    public bool[] niveauDebloque = new bool[10];

    public void Start(){
        
        for (int i = 0; i < (niveauDebloque.GetLength(0)); i++)
        {
        niveauDebloque[i] = false;
        }
        
    }

    

    public void Update(){
       
    }   
    
    
    public void ChargerNiveau(int niveau)
    {
       SceneManager.LoadScene("Niveau"+niveau);
    }

    public void Quit()
    {
        Application.Quit();
    }

}

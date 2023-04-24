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

    public void DeploquerNiveau(){
        int temp = 1;
        while (niveauDebloque[temp]){
            temp++;
        }
        niveauDebloque[temp]=true;
    }
    public void DeploquerNiveau(int n){
        niveauDebloque[n]=true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}

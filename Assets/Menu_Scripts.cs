using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Scripts : MonoBehaviour
{

    enum EtatMenu {
        MENU_PRINCIPALE,
        SELECTION_NIVEAU
    };

    EtatMenu etat_menu = EtatMenu.MENU_PRINCIPALE;
    public ArrayList nivaux = new ArrayList(1);


    

    public void Update(){
        switch (etat_menu){
            case EtatMenu.MENU_PRINCIPALE: print("a");break;
            case EtatMenu.SELECTION_NIVEAU: print("b");break;
        }
    }

   

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

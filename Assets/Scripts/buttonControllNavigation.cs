using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonControllNavigation : MonoBehaviour
{

    public void LoadScene(string name)
    {

        //Carregar cena de acordo com seu nome
        SceneManager.LoadScene(name);
    }

    public void Exit()
    {
        Application.Quit();
    }

  
}

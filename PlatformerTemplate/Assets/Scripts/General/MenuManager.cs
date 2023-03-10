using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Play()
    {
        //renvoie vers la scene qui s'appelle Levels
        SceneManager.LoadScene("Levels");
    }
}

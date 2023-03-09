using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelsManager : MonoBehaviour
{
    //fonction public qui envoie le joueur vers le niveau choisi
    public void Level1()
    {
        SceneManager.LoadScene("Niveau1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Niveau2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Niveau3");
    }
}

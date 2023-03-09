using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject m_GameOverUI;
    [SerializeField]
    private GameObject m_WinUI;

    [SerializeField]
    private PlayerController m_Player;

    private bool _isOver = false;

    public void FinishGame()
    {
        if (_isOver)
            return;

        _isOver = true;

        m_WinUI.SetActive(true);
        m_Player.Stop();
    }

    public void GameOver()
    {
        if (_isOver)
            return;

        _isOver = true;

        m_GameOverUI.SetActive(true);
        m_Player.Stop();
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

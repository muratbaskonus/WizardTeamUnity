using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    public PlayfabManager playfabManager;
    public GameObject gameOverUI;
    public GameObject leaderBoardUI;


    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
        {
            return;
        }
        if(PlayerStats.lives <= 0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        gameEnded = true;
        gameOverUI.SetActive(true);
        playfabManager.SendScore(PlayerStats.score);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void GetLeaderBoardButton()
    {
        gameOverUI.SetActive(false);
        leaderBoardUI.SetActive(true);
        playfabManager.GetLeaderboard();
    }
    public void BackToGameOver()
    {
        leaderBoardUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
}

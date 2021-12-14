using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    public GameObject gameOverUI;

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
    }
    
}

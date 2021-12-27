
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject optionsUI;
    public GameObject inputUI;
    public PlayfabManager playfabManager;
    public void PlayGame()
    {
        try { 
        SceneManager.LoadScene("MainScene");
            Debug.Log("OLDU");

        }catch
        {
            Debug.Log("Hata");
        }
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();

    }
    public void LoginButton()
    {
        playfabManager.DisplayNameUpdate();
        inputUI.SetActive(false);
        optionsUI.SetActive(true);

    }
}

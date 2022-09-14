using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void OpenAuthor()
    {
        Debug.Log("Created by HQ");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void onClickPlay()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1f;
    }

    public void onClickHome() 
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void onClickRestart()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsScreen;
    public GameObject startScreen;

    public void StartGame()
    {
        SceneManager.LoadScene("juego");
    }


    public void ActivateCreditsScreen()
    {
        creditsScreen.SetActive(true);
        startScreen.SetActive(false);
    }

    public void ActivateStartScreen()
    {
        creditsScreen.SetActive(false);
        startScreen.SetActive(true);
    }
}
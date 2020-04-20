using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScene : MonoBehaviour
{
    public AudioSource menuInteraction;
    public void quitGame()
    {
        menuInteraction.Play();
        Application.Quit();
        Debug.Log("Quit");
    }

    public void retryGame1()
    {
        menuInteraction.Play();
        SceneManager.LoadScene(1);
    }

    public void returnToMenu()
    {
        menuInteraction.Play();
        SceneManager.LoadScene(0);
    }
}

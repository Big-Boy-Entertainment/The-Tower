using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winScript : MonoBehaviour
{
    public GameObject unlockNextLevel;
    public AudioSource menuSound;

    private void Start()
    {
        unlockNextLevel.SetActive(false);
    }

    public void returnToMain()
    {
        menuSound.Play();
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        menuSound.Play();
        Application.Quit();
    }

    public void nextLevel()
    {
        menuSound.Play();
        unlockNextLevel.SetActive(true);
    }

    public void returnToScreen()
    {
        menuSound.Play();
        unlockNextLevel.SetActive(false);
    }
}

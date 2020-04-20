using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject levelSelector;
    public GameObject playButton;
    public GameObject quitButton;
    public GameObject instruction;
    // Start is called before the first frame update
    private void Start()
    {
        levelSelector.SetActive(false);
        instruction.SetActive(false);
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Play");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void enableLevelSelector()
    {
        levelSelector.SetActive(true);
        playButton.SetActive(false);
        quitButton.SetActive(false);
    }

    public void goBackToMenu()
    {
        playButton.SetActive(true);
        quitButton.SetActive(true);
        levelSelector.SetActive(false);
    }

    public void exitInstruction()
    {
        playButton.SetActive(true);
        quitButton.SetActive(true);
        instruction.SetActive(false);
    }

    public void enterInstruction()
    {
        playButton.SetActive(false);
        quitButton.SetActive(false);
        instruction.SetActive(true);
    }
}

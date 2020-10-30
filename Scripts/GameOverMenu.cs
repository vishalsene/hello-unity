using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Loads game scene when method is called.
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Should quit game. (Not implemented yet.)
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

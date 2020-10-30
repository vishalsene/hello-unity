using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Loads game scene when methos is called.
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Should quit game. (Not implemented yet.)
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

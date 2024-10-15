using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu; // Private variable that shows up in editor!
    
    public void Pause()
    {
        // This function is called when someone clicks the pause button
        // It should bring up the pause menu and freeze the game
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; 
    }
    public void Resume()
    {        
        // This function is called when someone clicks the play button
        // It should get rid of the pause menu and unfreeze the game
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        
    }
    public void Home(int sceneID)
    {
        // This function is called in game to return to the main menu
        // It should resume time and use the SceneManager to load the main menu
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
        
    }
}

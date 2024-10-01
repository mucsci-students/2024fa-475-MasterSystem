// GameManager.cs

// Handles the overarching state of the game: whether it's started or not, the current score, and when the level ends
using UnityEngine;
using UnityEngine.UI; // Required for working with UI elements

public class GameManager : MonoBehaviour
{
    public Text pipScoreText; // UI element to display player's progress towards objective
    public Text gameOverText; // UI element to display the game over message

    private int playerScore = 0; // Player's current score

    void Start(){
        // Ensure the game over text is hidden when the game starts
        gameOverText.enabled = false;
    }

    // Method to increase player's score
    public void AddScore(){
        playerScore++; 
        pipScoreText.text = playerScore.ToString(); // Update the score text on UI
    }

    // Method to handle game over state
    public void GameOver(){
        gameOverText.enabled = true; // Show game over text
        Time.timeScale = 0; // Freeze the game
    }

    // Method to restart the game 
    public void RestartGame(){
        Time.timeScale = 1; // Resume the game
        gameOverText.enabled = false; // Hide game over text
        playerScore = 0; // Reset player score
        pipScoreText.text = playerScore.ToString(); // Update score on UI
    }
}
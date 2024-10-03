// GameManager.cs

// Handles the overarching state of the game: whether it's started or not, the current score, and when the level ends
using UnityEngine;
using UnityEngine.SceneManagement; // Required for switching between scenes

public class GameManager : MonoBehaviour
{
    public UIManager uiManager; 
    public int playerScore;
    public int goal = 5;
    public int money;

    private bool gameOver = false;

    public void Start(){
        uiManager.updateUI(playerScore, money);
        Invoke("NewLevel", 1f);
    }

    // Method to increase player's score
    public void AddScore(){
        playerScore++; 
        if(playerScore>goal){
            GameOver(true);
        }
    }

    public void ChangeMoney(int amount){
        money += amount;
        uiManager.updateUI(playerScore, money);
        if(money<0){
            GameOver(false);
        }
    }



    // Methods to handle game over state
    public void GameOver(bool winstatus){
        gameOver = true;
        uiManager.displayGameOver(winstatus);
        Invoke("ReturnToMenu", 2f);
    }

    // Get into game by loading level scene
    void NewLevel(){
        SceneManager.LoadScene("GameLevel");
    }


    // Return to menu by loading other scene
    void ReturnToMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
// GameManager.cs

// Handles the overarching state of the game: whether it's started or not, the current score, and when the level ends
using UnityEngine;
using UnityEngine.SceneManagement; // Required for switching between scenes
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager; 
    public int playerScore = 0;
    public int goal = 5;
    public int money = 0;

    public Button newGameButton;

    private bool gameOver = false;

    public void Start(){
        //Requiered initialization of a UIManager
        uiManager = new UIManager();
        uiManager.updateUI(money, playerScore);
        newGameButton.onClick.AddListener(NewLevel);
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
        uiManager.updateUI(money, playerScore);
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
        //uiManager.removeTitle();
        SceneManager.LoadScene("GameLevel");
    }


    // Return to menu by loading other scene
    void ReturnToMenu(){
        //uiManager.returnTitle();
        SceneManager.LoadScene("MainMenu");
    }
}
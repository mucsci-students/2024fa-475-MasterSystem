// GameManager.cs

// Handles the overarching state of the game: whether it's started or not, the current score, and when the level ends
using UnityEngine;
using UnityEngine.SceneManagement; // Required for switching between scenes
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager; 

    public PipManager pipManager; 
    public int playerScore = 0;
    public int goal = 5;
    public int money = 0;

    public Button newGameButton;

    private bool gameOver = false;

    public void Start(){
        uiManager = this.GetComponent<UIManager>();

        pipManager = this.GetComponent<PipManager>();

        newGameButton.onClick.AddListener(LoadLevel);
    }

    // Method to increase player's score
    public void AddScore(){
        playerScore++; 
        uiManager.updateScore(playerScore);
        if(playerScore>goal){
            GameOver(true);
        }
    }

    public void ChangeMoney(int amount){
        money += amount;
        uiManager.updateMoney(money);
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
    // Public and renamed for clarity
    public void LoadLevel(){
        //uiManager.removeTitle();
        SceneManager.LoadScene("GameLevel");
        Invoke("updateUI", 2f);
        Invoke("spawnPip", 2f);
    }

    public void updateUI(){
        uiManager.updateUI();
    }

    public void spawnPip(){
        pipManager.SpawnPip();
    }


    // Return to menu by loading other scene
    public void ReturnToMenu(){
        //uiManager.returnTitle();
        SceneManager.LoadScene("MainMenu");
    }
}
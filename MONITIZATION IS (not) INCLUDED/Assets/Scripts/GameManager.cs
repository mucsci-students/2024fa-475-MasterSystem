// GameManager.cs

// Handles the overarching state of the game: whether it's started or not, the current score, and when the level ends
using UnityEngine;
using UnityEngine.SceneManagement; // Required for switching between scenes
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button newGameButton;
    private int money = 0;
    public Text moneyLabel;
    public int Money{
        get{return money;}
        set{
            money = value;
            moneyLabel.GetComponent<Text>().text = "GoFundMe Balance: " + money;
        }
    }    
    
    private int score = 0;
    public int goal = 5;
    public Text scoreLabel;
    public int Score{
        get{return score;}
        set{
            score = value;
            scoreLabel.GetComponent<Text>().text = "Progress: " + score + "/" + goal;
        }
    }

    private int depth = 1; //Between 1 and 9
    public Text depthLabel;
    public int Depth{
        get{return depth;}
        set{
            depth = value;
            depthLabel.GetComponent<Text>().text = "Depth: " + depth;
        }
    }


    private bool gameOver = false;
    public Text gameOverText;

    public void Start(){
        newGameButton.onClick.AddListener(LoadLevel);
        Money = 5000;
        Score = 0;
        Depth = 1;
        gameOverText.enabled = false;
        moneyLabel.enabled = false;
        scoreLabel.enabled = false;
        depthLabel.enabled = false;

    }

    // Method to increase player's score
    public void ChangeScore(int amount){
        Score += amount; 
        if(Score>goal){
            Depth += 1;
            goal+=10;
        }
    }

    public void ChangeMoney(int amount){
        Money += amount;
        if(money<0){
            GameOver(false);
        }
    }
    public int GetMoney()
    {
        return money;
    }
    public int GetScore()
    {
        return score;
    }



    // Methods to handle game over state
    public void GameOver(bool winstatus){
        gameOver = true;
        gameOverText.enabled = true;
        gameOverText.text = winstatus ? "You win!" : "You lose!";
    
        Invoke("ReturnToMenu", 5f);
    }

    // Get into game by loading level scene
    // Public and renamed for clarity
    public void LoadLevel(){
        scoreLabel.enabled = true;
        moneyLabel.enabled = true;
        depthLabel.enabled = true;
        SceneManager.LoadScene("GameLevel");
    }



    // Return to menu by loading other scene
    public void ReturnToMenu(){
        scoreLabel.enabled = false;
        moneyLabel.enabled = false;
        depthLabel.enabled = false;
        SceneManager.LoadScene("MainMenu");
    }
}
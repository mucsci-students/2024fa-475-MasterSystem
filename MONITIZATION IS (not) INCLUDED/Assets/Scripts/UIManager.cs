// UIManager.cs

// Places static 2D UI elements onto the screen that show the player their current standing in the level
// Should be mostly working unless I'm forgetting stuff

using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text moneyText;
    public Text pipCountText;
    public Text gameOverText;

    public Text titleText;

    public Button newGameButton;

    void Start(){
        gameOverText.enabled = false;
    }

    public void updateUI(int money, int pipCount){
        //moneyText.text = "Balance: $" + money.ToString();
        //pipCountText.text = "Good Pips: " + pipCount.ToString();
    }

    public void displayGameOver(bool winstatus){
        gameOverText.enabled = true;
        gameOverText.text = winstatus ? "You win!" : "You lose!";
    }

    // public void removeTitle(){
    //     titleText.OnDisable = false;
    //     newGameButton.OnDisable = false;
    // }

    // public void returnTitle(){
    //     titleText.enabled = true;
    //     newGameButton.enabled = true;
    // }
}
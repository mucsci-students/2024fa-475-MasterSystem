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

    public void Start(){
        
    }

    public void updateUI(){
        moneyText = GameObject.Find("/Canvas/moneyText").GetComponent(typeof(Text)) as Text;
        pipCountText = GameObject.Find("/Canvas/pipCountText").GetComponent(typeof(Text)) as Text;
        gameOverText = GameObject.Find("/Canvas/gameOverText").GetComponent(typeof(Text)) as Text;

        gameOverText.enabled = false;

        
    }

    public void updateMoney(int money){
        moneyText.text = "Balance: $" + money.ToString();
    }

    public void updateScore(int Score){
        pipCountText.text = "Good Pips: " + Score.ToString();
    }

    public void displayGameOver(bool winstatus){
        gameOverText.enabled = true;
        gameOverText.text = winstatus ? "You win!" : "You lose!";
    }
}
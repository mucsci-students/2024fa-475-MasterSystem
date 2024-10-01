// UIManager.cs

// Places static 2D UI elements onto the screen that show the player their current standing in the level
// Should be mostly working unless I'm forgetting stuff

using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text moneyText;
    public Text pipCountText;

    private int money;
    private int pipCount;

    void Start(){
        updateUI();
    }

    void updateUI(){
        moneyText.text = "Balance: $" + money;
        pipCountText.text = "Good Pips: " + pipCount;
    }

    public void addMoney(int dollars){
        money+=dollars;
        updateUI();
    }

    public void addPipCount(int pips){
        pipCount+=pips;
        updateUI();
    }
}
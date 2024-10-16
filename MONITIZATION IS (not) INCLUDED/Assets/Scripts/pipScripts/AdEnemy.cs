// AdEnemy.cs

// Creates an Ad enemy
using UnityEngine;

public class AdEnemy : Pip
{

public override void Start(){
    pipBody = GetComponent<Rigidbody2D>();
    GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
    int depth = gameManager.getDepth();
    speed = 2f + depth;
    hp = 1;
    isEnemy = true;
    moneyGive = 20;
    scoreGive = 0;
    }
}
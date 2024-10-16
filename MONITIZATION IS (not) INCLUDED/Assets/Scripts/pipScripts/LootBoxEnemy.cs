// LootBoxEnemy.cs

// Creates an LB enemy
using UnityEngine;

public class LootBoxEnemy : Pip
{

    public override void Start(){
        pipBody = GetComponent<Rigidbody2D>();
        GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
    int depth = gameManager.getDepth();
        speed = 0.5f + (depth/4f);
        hp = 4;
        isEnemy = true;
        moneyGive = 50;
        scoreGive = 0;
    }
}
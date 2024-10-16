// LootBoxEnemy.cs

// Creates an LB enemy
using UnityEngine;

public class LootBoxEnemy : Pip
{

    public override void Start(){
        pipBody = GetComponent<Rigidbody2D>();
        speed = 0.5f;
        hp = 4;
        isEnemy = true;
        moneyGive = 50;
        scoreGive = 0;
    }
}
// LootBoxEnemy.cs

// Creates an LB enemy
using UnityEngine;

public class LootBoxEnemy : Pip
{

    public override void Start(){
        pipBody = GetComponent<Rigidbody2D>();
        GameManager gameManager = FindObjectOfType<GameManager>();
        speed = 0.5f * gameManager.Depth;
        hp = 4;
        isEnemy = true;
    }
}
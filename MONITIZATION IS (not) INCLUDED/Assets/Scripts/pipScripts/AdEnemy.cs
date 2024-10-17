// AdEnemy.cs

// Creates an Ad enemy
using UnityEngine;

public class AdEnemy : Pip
{

public override void Start(){
    pipBody = GetComponent<Rigidbody2D>();
    GameManager gameManager = FindObjectOfType<GameManager>();
    speed = 2f * gameManager.Depth;
    hp = 1;
    isEnemy = true;
    }
}
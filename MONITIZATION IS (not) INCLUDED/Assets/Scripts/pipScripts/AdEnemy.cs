// AdEnemy.cs

// Creates an Ad enemy
using UnityEngine;

public class AdEnemy : Pip
{

public override void Start(){
    pipBody = GetComponent<Rigidbody2D>();
    GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
    int depth = gameManager.getDepth();
    speed = 2f + (depth/4f);
    hp = 1;
    isEnemy = true;
    moneyGive = 20;
    randImage = false;
    hasCollided = false;
    }

    public void FixedUpdate(){
        pipBody.velocity = (new Vector2(0f, -speed));
    }
}
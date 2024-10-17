using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : Pip
{
    // Start is called before the first frame update
    public override void Start()
    {
        pipBody = GetComponent<Rigidbody2D>();
        GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
        int depth = gameManager.getDepth();
        speed = 0.5f + (depth/4f);
        hp = 4;
        isEnemy = true;
        moneyGive = 50;
        randImage = false;
    }

    public void FixedUpdate(){
        pipBody.velocity = (new Vector2(0f, -speed));
    }
}

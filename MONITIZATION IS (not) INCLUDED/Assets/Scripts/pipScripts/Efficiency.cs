using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efficiency : Pip
{
    // Start is called before the first frame update
    public override void Start()
    {
        pipBody = GetComponent<Rigidbody2D>();
        GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
        speed = 1f;
        hp = 1;
        moneyGive = 350;
        randImage = false;
        hasCollided = false;
    }


    public void FixedUpdate(){
        pipBody.velocity = (new Vector2(0f, -speed));
    }
}

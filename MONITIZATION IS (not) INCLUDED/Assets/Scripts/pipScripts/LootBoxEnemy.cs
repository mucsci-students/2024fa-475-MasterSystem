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
        randImage = false;
        hasCollided = false;
    }

    public void FixedUpdate(){
        pipBody.velocity = (new Vector2(0f, -speed));
    
        if(hasCollided = true){
            gameObject.GetComponent<Transform>().Translate(new Vector3(0, (speed*2), 0) * Time.deltaTime);
            hasCollided = false;
        }    
    }
    public void OnCollisionEnter2D(Collision2D collision){
            hasCollided = true;
        }
}
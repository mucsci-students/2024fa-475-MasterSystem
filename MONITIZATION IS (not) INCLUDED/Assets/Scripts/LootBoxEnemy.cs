// LootBoxEnemy.cs

// Creates an LB enemy
using UnityEngine;

public class LootBoxEnemy : Pip
{
    
    private Rigidbody2D pipBody;

    public override void Start(){
        pipBody = GetComponent<Rigidbody2D>();
        speed = 0.5f;
        hp = 4;
        isEnemy = true;
    }

    public override void assignScript(GameObject pipPrefab){
        pipPrefab.AddComponent<LootBoxEnemy>();
    }

    public void FixedUpdate(){
        pipBody.velocity = (new Vector2(0f, -speed));
    }

}
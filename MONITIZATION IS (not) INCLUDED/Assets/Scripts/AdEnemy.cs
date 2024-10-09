// AdEnemy.cs

// Creates an Ad enemy
using UnityEngine;

public class AdEnemy : Pip
{
    
    private Rigidbody2D pipBody;

public override void Start(){
    pipBody = GetComponent<Rigidbody2D>();
    speed = 2f;
    hp = 1;
    isEnemy = true;
    }

public override void assignScript(GameObject pipPrefab){
    pipPrefab.AddComponent<AdEnemy>();
}

    public void FixedUpdate(){
        pipBody.velocity = (new Vector2(0f, -speed));
    }
}
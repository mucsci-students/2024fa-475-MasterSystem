// AdEnemy.cs

// Creates an Ad enemy
using UnityEngine;

public class AdEnemy : Pip
{

public override void Start(){
    pipBody = GetComponent<Rigidbody2D>();
    speed = 2f;
    hp = 1;
    isEnemy = true;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseProjectile : Projectile
{
public override void Start(){
    pipBody = GetComponent<Rigidbody2D>();
    damage = 1;
    aoe = false;
    }
    public void FixedUpdate(){
        pipBody.velocity = (new Vector2(0f, -2f));
    } 
}

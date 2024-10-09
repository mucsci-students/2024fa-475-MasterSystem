using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodPip : Pip
{
    private Rigidbody2D pipBody;
    // Start is called before the first frame update
    public override void Start()
    {
        pipBody = GetComponent<Rigidbody2D>();
        speed = 1f;
        hp = 1;
        isEnemy = false;
    }

    public override void assignScript(GameObject pipPrefab){
        pipPrefab.AddComponent<GoodPip>();
    }

    public void FixedUpdate(){
        pipBody.velocity = (new Vector2(0f, -speed));
    }
}

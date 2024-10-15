using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodPip : Pip
{
    // Start is called before the first frame update
    public override void Start()
    {
        pipBody = GetComponent<Rigidbody2D>();
        speed = 1f;
        hp = 1;
        isEnemy = false;
    }
}

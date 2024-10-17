using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirewallTower : Tower
{
    // Start is called before the first frame update
    public Sprite swap;
    public override void Start()
    {
        cost = 1;
        hp = 10;
    }

    public void OnTriggerEnter2D(Collider2D p){
        if(p.gameObject.tag == "BadpipPreFab"){
            p.gameObject.GetComponent<Pip>().TakeDamage();
            hp--;
            if(hp == 0){
                gameObject.GetComponent<SpriteRenderer>().sprite = swap;
                Destroy(gameObject, 5f);
            }
            
        }
    }
}

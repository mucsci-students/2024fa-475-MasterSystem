using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTower : Tower
{
    // Start is called before the first frame update
    public override void Start()
    {
        cost = 0;
        hp = 1;
    }

    public void OnTriggerEnter2D(Collider2D p){
        if(p.gameObject.tag == "pipPreFab"){
            GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
            gameManager.ChangeMoney(p.gameObject.GetComponent<Pip>().moneyGive);
            Destroy(p.gameObject);
            
        }else if (p.gameObject.tag == "BadpipPreFab"){
            Destroy(gameObject);
        }
    }
}

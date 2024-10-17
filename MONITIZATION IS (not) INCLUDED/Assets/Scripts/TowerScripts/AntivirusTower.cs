using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntivirusTower : Tower
{
    // Start is called before the first frame update
    public Sprite swap;
    public override void Start()
    {
        cost = 500;
        hp = 1;
    }

    public void OnTriggerEnter2D(Collider2D p){
        if(p.gameObject.tag == "VirusPip"){
            GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
            gameManager.ChangeMoney(p.gameObject.GetComponent<Pip>().moneyGive);
            Destroy(p.gameObject);
            gameObject.GetComponent<SpriteRenderer>().sprite = swap;
            Destroy(gameObject, 5f);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcan : MonoBehaviour
{
    public Sprite swap;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D trash){
        if(trash.gameObject.tag == "BadpipPreFab"){
            Destroy(trash.gameObject);
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            gameObject.GetComponent<SpriteRenderer>().sprite = swap;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D trash){
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.ChangeScore(-1);
        if(trash.gameObject.tag == "pipPreFab")
            Destroy(trash.gameObject);
    }
}

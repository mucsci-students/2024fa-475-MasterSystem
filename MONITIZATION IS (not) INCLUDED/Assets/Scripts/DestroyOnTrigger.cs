using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public void EnterTrigger(Collider2D trash){
        Destroy(trash.gameObject);
    }
}

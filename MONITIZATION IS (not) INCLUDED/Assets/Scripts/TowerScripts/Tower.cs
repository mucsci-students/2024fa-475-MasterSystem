using UnityEngine;

public abstract class Tower : MonoBehaviour
{    
    public int cost;

    public int hp;
    // Use this for initialization
    public abstract void Start();

    public void OnTriggerEnter(Collider other){
        hp--;
        if(hp <= 0){
            Destroy(gameObject);
        }
    }
}
//Pip.cs

//Handles a generic pip object that other pips will inherit from
using UnityEngine;

public abstract class Pip : MonoBehaviour
{
    public float speed;
    public int hp;
    public bool isEnemy;
    public int moneyGive;
    public bool randImage;

    public bool hasCollided;
    public GameManager gameManager;

    public Rigidbody2D pipBody;

    // Initialize
    public abstract void Start();

    

    // Method to take damage
    public void TakeDamage()
    {
        hp --;
        if (hp <= 0)
        {
            GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
            gameManager.ChangeMoney(moneyGive);
            
            Die();
        }
    }

    // Handle destruction of the pip inside the grid
    public void Die()
    {
        Destroy(gameObject);
    }

    // public void OnMouseUp()
    // {
    //     TakeDamage();
    // }
}
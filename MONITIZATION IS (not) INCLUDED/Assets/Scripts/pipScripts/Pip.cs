//Pip.cs

//Handles a generic pip object that other pips will inherit from
using UnityEngine;

public abstract class Pip : MonoBehaviour
{
    public float speed;
    public int hp;
    public bool isEnemy;

    public Rigidbody2D pipBody;

    // Initialize
    public abstract void Start();

    public void FixedUpdate(){
        pipBody.velocity = (new Vector2(0f, -speed));
    }

    // Method to take damage
    public void TakeDamage()
    {
        hp --;
        if (hp <= 0)
        {
            Die();
        }
    }

    // Handle destruction of the pip inside the grid
    public void Die()
    {
        Destroy(gameObject);
    }

    public void OnMouseUp()
    {
        TakeDamage();
    }
}
//Pip.cs

//Handles a generic pip object that other pips will inherit from
using UnityEngine;

public class Pip : MonoBehaviour
{
    public float speed = 1f;
    public int hp = 1;
    public bool isEnemy;
    public int pipID;
    private Rigidbody2D rigidBody;

    // Initialize
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Basic movement behavior
    public virtual void Move() // Virtual methods can be overridden: this allows certain pips to move at different speeds
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    // Method to take damage
    public void TakeDamage(int damage)
    {
        hp -= damage;
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
}
//Pip.cs

//Handles a generic pip object that other pips will inherit from
using UnityEngine;

public abstract class Pip : MonoBehaviour
{
    public float speed = 1f;
    public int hp = 1;
    public bool isEnemy;

    // Initialize
    public abstract void Start();

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

    public abstract void assignScript(GameObject pipPrefab);
}
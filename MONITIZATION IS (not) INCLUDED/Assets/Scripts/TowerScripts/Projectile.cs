using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public int damage;
    public bool aoe;
    public abstract void Start();
}

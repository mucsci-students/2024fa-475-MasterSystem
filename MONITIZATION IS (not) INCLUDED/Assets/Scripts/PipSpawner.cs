// PipManager.cs

// Creates the general framework for a pip: it has a speed, reward bonus, health amount, and flag to indicate if it's good or bad
using UnityEngine;
using System;

public class PipManager : MonoBehaviour
{
    //Public variables
    public GameObject[] pips = new GameObject[3];
    
    
    public float delay;

    //Private variables
    
    private GameObject randomPip;

    private Rigidbody2D pipBody;

    private float pipSpeed;

    public void Start()
    {        
        transform.position = new Vector3(-3f, 8f, 0f);
        SpawnPip();
    }

    public void SpawnPip()
    {        
        //generates a random number between 0 and 2
        int ran = UnityEngine.Random.Range(0,3);
        //finds a pip based on random number
        randomPip = pips[ran];

        

        //This will generate a random colomn for pips to spawn in, it should be random every time a pip is created maybe
        //Shifted to account for new grid.
        int spawnCol = UnityEngine.Random.Range(0,7);

        randomPip = Instantiate(randomPip,transform);
        
        randomPip.transform.position += new Vector3(spawnCol * 1.82f, 0f, 0f);
        
        //randomPip.transform.position = transform.position /*+ new Vector3(spawnCol * 1.82f,0f,0f)*/;
        
        delay = UnityEngine.Random.Range(5f,8f);
        Invoke("SpawnPip", delay);
    }



    // Handle pushing pips by the player
    public void PushPip()
    {
        // Current behavior: Destroy pip

        // Add specific push behavior for good and bad pips here
    }
}
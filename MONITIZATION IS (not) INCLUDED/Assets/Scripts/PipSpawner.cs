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
    private GridManager gridManager;
    private GameObject randomPip;

    private Rigidbody2D pipBody;

    private float pipSpeed;

    public void Start()
    {        
        gridManager = FindObjectOfType<GridManager>();
        SpawnPip();
    }

    public void SpawnPip()
    {        
        //generates a random number between 0 and 2
        int ran = UnityEngine.Random.Range(0,2);

        //finds a pip based on random number
        randomPip = pips[ran];

        //This will generate a random colomn for pips to spawn in, it should be random every time a pip is created maybe
        //Shifted to account for new grid.
        int spawnCol = UnityEngine.Random.Range(-2,6); 
        
        Instantiate(randomPip, new Vector3((spawnCol*1.82f)+0.65f, 7, 0), Quaternion.identity); //only spawning good pips
        //gridManager.PlaceObjectInTile(pip, gridManager.rows-1, spawnCol);
        
        delay = UnityEngine.Random.Range(1f,3f);
        Invoke("SpawnPip", delay);
    }



    // Handle pushing pips by the player
    public void PushPip()
    {
        // Current behavior: Destroy pip

        // Add specific push behavior for good and bad pips here
    }
}
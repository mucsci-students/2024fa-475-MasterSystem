// PipManager.cs

// Spawns, moves, and destroys each instance of a pip that comes across the screen
using UnityEngine;

public class PipManager : MonoBehaviour
{
    public GameObject pipPrefab;
    public float pipMoveInterval = 2f;
    public float speed = -2f;
    
    private GridManager gridManager;
    public float delay;

    public void Start()
    {        
        
        Rigidbody2D rigidBody;
        rigidBody = GetComponent<Rigidbody2D>();
        // Give meteor an initial downward velocity
        rigidBody.velocity = new Vector2(0, speed);
        gridManager = FindObjectOfType<GridManager>();
        SpawnPip();
    }

    public void SpawnPip()
    {        
        
        //This will generate a random colomn for pips to spawn in, it should be random every time a pip is created maybe
        //Shifted to account for new grid.
        int spawnCol = Random.Range(-2,6); 
        
        Instantiate(pipPrefab, new Vector3((spawnCol*1.82f)+0.65f, 7, 0), Quaternion.identity); //only spawning good pips
        //gridManager.PlaceObjectInTile(pip, gridManager.rows-1, spawnCol);
        
        delay = Random.Range(1f,3f);
        Invoke("SpawnPip", delay);
    }

    // Push pips down the screen 
    public void ScrollPip()
    {
        
    }




    // Handle pushing pips by the player
    public void PushPip()
    {
        
        // Add specific push behavior for good and bad pips here
    }
}
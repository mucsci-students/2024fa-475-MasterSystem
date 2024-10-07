// PipManager.cs

// Creates the general framework for a pip: it has a speed, reward bonus, health amount, and flag to indicate if it's good or bad
using UnityEngine;

public class PipManager : MonoBehaviour
{
    public GameObject pipPrefab;
    public float speed = -1f;
    public float reward = 0;
    public float hp = 1;
    public int isEnemy = 0;
    public int pipID; //Store a unique identifier for each pip
    public int row = 0;
    public int col = 0;
    private GridManager gridManager;
    public float delay;

    public void Start()
    {        
        
        Rigidbody2D rigidBody;
        rigidBody = GetComponent<Rigidbody2D>();

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





    // Handle pushing pips by the player
    public void PushPip()
    {
        // Current behavior: Destroy pip

        // Add specific push behavior for good and bad pips here
    }
}
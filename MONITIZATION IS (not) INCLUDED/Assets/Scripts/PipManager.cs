// PipManager.cs

// Spawns, moves, and destroys each instance of a pip that comes across the screen
// Currently super broken: only spawns good pips and I don't even think it does that
using UnityEngine;

public class PipManager : MonoBehaviour
{
    public GameObject goodPipPrefab;
    public GameObject badPipPrefab;
    public float pipMoveInterval = 2f;

    private GridManager gridManager;
    private float timeSinceLastMove;

    void Start()
    {
        gridManager = FindObjectOfType<GridManager>(); // Found this online but idk C# so feel free to replace
        SpawnPips();
    }

    void SpawnPips()
    {
        //This will generate a random colomn for pips to spawn in, it should be random every time a pip is created maybe
        int spawnCol = Random.Range(1,6); 
        
        GameObject pip = Instantiate(goodPipPrefab, new Vector3(spawnCol, gridManager.rows - 1, 0), Quaternion.identity); //only spawning good pips
        gridManager.PlaceObjectInTile(pip, gridManager.rows-1, spawnCol);
    }

    // Handle pushing pips by the player
    public void PushPip()
    {
        
        // Add specific push behavior for good and bad pips here
    }
}
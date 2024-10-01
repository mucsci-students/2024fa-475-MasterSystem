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
        // I have no idea how to loop this
        int spawnCol; // = Random()?? idk how
        
        GameObject pip = Instantiate(goodPipPrefab, new Vector3(spawnColumn, gridManager.rows - 1, 0)) //only spawning good pips
        GridManager.PlaceObjectInTile(pip, gridManager.rows-1, spawnCol)
    }

    // Handle pushing pips by the player
    public void PushPip()
    {
        
        // Add specific push behavior for good and bad pips here
    }
}
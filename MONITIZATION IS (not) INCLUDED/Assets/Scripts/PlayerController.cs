// PlayerController.cs

// Allows the player to move across the grid and interact with tiles
// Getting keyboard movement was lowkey kinda tough so I haven't worked on adding the bad pip handler yet, only the good ones
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private GridManager gridManager;

    private Vector2Int currentPos; // Player's position on the grid

    public void Start(){
        gridManager = FindObjectOfType<GridManager>();
        currentPos = new Vector2Int(0, 0); // Starting at the top-left corner
        UpdatePlayerPosition();
    }

    public void Update(){
        ArrowKeyMove();
        HandleInteraction();
    }

    // Move the player on the grid
    public void ArrowKeyMove(){
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentPos.y < gridManager.columns - 1)
        {
            currentPos.y++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && currentPos.y > 0)
        {
            currentPos.y--;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && currentPos.x > 0)
        {
            currentPos.x--;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && currentPos.x < gridManager.rows - 1)
        {
            currentPos.x++;
        }

        UpdatePlayerPosition();
    }

    // Move the player GameObject visually
    public void UpdatePlayerPosition(){
        transform.position = new Vector3(currentPos.x * gridManager.tileSize, currentPos.y * gridManager.tileSize, 0);
    }

    // Interact with the grid (e.g., push commits or place towers)
    public void HandleInteraction(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Interaction logic, for example, pushing pips
            GameObject currentObject = gridManager.grid[currentPos.x, currentPos.y];

            if (currentObject != null)
            {
                // Push or interact with the object
                Destroy(currentObject.gameObject);
            }
        }
        // IMPLEMENT PRESS Q TO TRASH BAD PIPS
    //}
}
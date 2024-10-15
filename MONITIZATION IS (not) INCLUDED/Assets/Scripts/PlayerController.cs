// PlayerController.cs

// Allows the player to move across the grid and interact with tiles
// Getting keyboard movement was lowkey kinda tough so I haven't worked on adding the bad pip handler yet, only the good ones
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private GridManager gridManager;

    private Vector2Int currentPos; // Player's position on the grid
    public GameObject selectedTowerPrefab;
    
    // Create references to all towers in the deck
    public GameObject FirewallPrefab;
    public GameObject AntivirusPrefab;
    public GameObject RAMPrefab;
    public GameObject MousePrefab;

    public void Start(){
        gridManager = FindObjectOfType<GridManager>();
        currentPos = new Vector2Int(4, 0); // Starting at the bottom-left corner
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
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
            currentPos.y++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && currentPos.y > 0)
        {
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
            currentPos.y--;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && currentPos.x > 4)
        { 
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
            currentPos.x--;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && currentPos.x < gridManager.rows - 1)
        {
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
            currentPos.x++;
        }

        UpdatePlayerPosition();
    }

    // Move the player GameObject visually
    public void UpdatePlayerPosition(){
        transform.position = gridManager.offsetOrigin + new Vector3(currentPos.x * gridManager.tileSize, currentPos.y * gridManager.tileSize, 0);
    }

    // Interact with the grid (e.g., selecting or place towers)
    public void HandleInteraction(){
        if (Input.GetKeyDown(KeyCode.Space) && selectedTowerPrefab != null)
        {
            // Check if the current tile is empty
            if (gridManager.IsTileEmpty(currentPos.x, currentPos.y))
            {
                // Spawn the selected tower
                GameObject tower = Instantiate(selectedTowerPrefab, gridManager.offsetOrigin + new Vector3(currentPos.x * gridManager.tileSize, currentPos.y * gridManager.tileSize, 0), Quaternion.identity);
                gridManager.PlaceObjectInTile(tower, currentPos.x, currentPos.y);
            }
        }

        // Select towers with 1-4 keys
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            selectedTowerPrefab = FirewallPrefab;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            selectedTowerPrefab = AntivirusPrefab;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4)){
            selectedTowerPrefab = RAMPrefab;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)){
            selectedTowerPrefab = MousePrefab;
        }

        // Unselect with escape key
        if (Input.GetKeyDown(KeyCode.Escape)){
            selectedTowerPrefab = null;
        }
        
        // Implement Q to trash bad pips (not implemented yet)
    }

}
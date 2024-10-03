using UnityEngine;

public class BackgroundRepeater : MonoBehaviour
{
    public GameObject tilePrefab; 
    public Camera mainCamera; 
    public Vector2 tileSize; 

    void Start()
    {
        // Fill the entire camera view with tiles
        FillBackgroundWithTiles();
    }

    // Function to fill the background with repeated tiles
    void FillBackgroundWithTiles()
    {
        // Calculate screen bounds in world units
        Vector2 screenBounds = GetScreenBounds();

        tileSize = new Vector2(screenBounds.x , screenBounds.y );

        // Calculate the starting position based on the camera center
        Vector3 startPosition = mainCamera.transform.position - new Vector3(screenBounds.x / 2, screenBounds.y / 2, 0);

        // Spawn tiles to fill the camera view
        for (float x = startPosition.x; x < startPosition.x + screenBounds.x; x += tileSize.x)
        {
            for (float y = startPosition.y; y < startPosition.y + screenBounds.y; y += tileSize.y)
            {
                Instantiate(tilePrefab, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }

    // Function to calculate screen bounds in world coordinates
    Vector2 GetScreenBounds()
    {
        int height = Screen.height;
        int width = Screen.width;

        return new Vector2(width, height);
    }
}
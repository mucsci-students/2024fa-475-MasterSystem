using UnityEngine;

public class BackgroundRepeater : MonoBehaviour
{
    public Sprite background; 
    public Camera mainCamera; 
    public Vector2 tileSize; 

    private GameObject backgroundImg;

    void Start()
    {
        // Fill the entire camera view with tiles
    }


    // Function to calculate screen bounds in world coordinates
    Vector2 GetScreenBounds()
    {
        int height = Screen.height;
        int width = Screen.width;

        return new Vector2(width, height);
    }
}
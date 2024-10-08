// GridManager.cs

//Manages the grid structure and keeps track of where objects are placed
/*  64x64 grid modeled as 8x8 tiles: 
Could give us more control when we need it (like for animation) while abstracting for larger scale use (background)
        Each tile can hold either a pip or a tower. 
        The player moves around the grid on this 8x8 layer.
    Pips fall from the top row of the grid and move downward over time. 
        Each pip occupies one grid (not tile) box. 
        That is, pips move on the 64x64 layer

HOWEVER, FOR SIMPLICITY'S SAKE IT IS JUST 8x8 RIGHT NOW
*/

using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int rows = 8;
    public int columns = 8;
    public float tileSize = 1f;
    
    // We use a 2D array to represent the board
    public GameObject[,] grid; 

    void Start(){
        InitializeGrid();
    }

    // Initialize the grid with empty spaces
    void InitializeGrid(){
        grid = new GameObject[rows, columns];

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                Vector3 position = new Vector3(x * tileSize, y * tileSize, 0);
                // Spawn specific grids (seeds) here
            }
        }
    }

    // Check if a specific tile is empty
    public bool IsTileEmpty(int row, int column){
        return grid[row, column] == null;
    }

    // Place an object at a specific tile
    public void PlaceObjectInTile(GameObject obj, int row, int column){
        grid[row, column] = obj;
    }

    // Remove an object from a specific tile
    public void RemoveObjectFromTile(int row, int column){
        grid[row, column] = null;
    }
}
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
Changed to 6x12 because it fits well within the playspace with tilesize 1.8x1.8
*/

using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int columns = 6;
    public int rows = 12;
    public float tileSize = 1.82f;
    public Vector3 offsetOrigin = new Vector3(-10.25f,-4, 0);
    
    // We use a 2D array to represent the board
    public GameObject[,] grid; 

    public void Start(){
        InitializeGrid();
    }

    // Initialize the grid with empty spaces
    public void InitializeGrid(){
        grid = new GameObject[rows, columns];

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                //Offset to move origin to bottom left.
                Vector3 position = offsetOrigin + new Vector3(x * tileSize, y * tileSize, 0);
                //Changed grid[row, column] to row[x, y] to fix a compilation error.
                //Feel free to change if this wasn't intended.
                grid[x, y] = null;
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

    // Remove any objects within a specific tile
    public void EmptyTile(int row, int column){
        grid[row, column] = null;
    }
}
// TowerManager.cs

// More work needed
// Spawns towers where the user places them and transmits various effects to pips on the board

using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public GameObject towerPrefab;

    private GridManager gridManager; // To relate the tower placement to the grid
    private GameManager gameManager; // To update and access the money and score
    private int cost; 
    

    void Start()
    {   
       
        gridManager = FindObjectOfType<GridManager>(); 
        gameManager = FindObjectOfType<GameManager>();
    }


    public void placeTower(Vector2Int position)
    {
        //if(gameManager.money > cost){
            if (gridManager.IsTileEmpty(position.x, position.y)){
                GameObject tower = Instantiate(towerPrefab, new Vector3(position.x, position.y, 0), Quaternion.identity);
                gridManager.PlaceObjectInTile(tower, position.x, position.y);
            }
        //}
    }


}
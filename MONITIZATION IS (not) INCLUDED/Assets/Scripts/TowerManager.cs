// TowerManager.cs

// More work needed
// Spawns towers where the user places them and transmits various effects to pips on the board

using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public GameObject towerPrefab;

    private GridManager gridManager;

    void Start(){
        gridManager = FindObjectOfType<GridManager>(); // Again someone lmk if this is right
    }

    public void placeTower(Vector2Int position){
        if (gridManager.IsTileEmpty(position.x, position.y)){
            GameObject tower = Instantiate(towerPrefab, new Vector3(position.x, position.y, 0), Quaternion.identity);
            gridManager.PlaceObjectInTile(tower, position.x, position.y);
        }
    }

    public void doStuff(){}
}
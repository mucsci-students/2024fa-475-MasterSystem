using UnityEngine;
using System.Collections;

public class PlaceTower : MonoBehaviour
{

    public GameObject towerPrefab;
    private GameObject tower;
    public GameManager GameManager;

    // Use this for initialization
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private bool CanPlaceTower()
    {
        int cost = towerPrefab.GetComponent<Tower>().cost;
        return tower == null && GameManager.Money >= cost;
    }

    //1
    void OnMouseUp(){
        
       
            tower = (GameObject) Instantiate(towerPrefab, transform.position, Quaternion.identity);
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
        if (CanPlaceTower()){
            GameManager.Money -= tower.GetComponent<Tower>().cost;
        }
        else{
            //play bad buzzer noise to indicate failure
        }
    }


}

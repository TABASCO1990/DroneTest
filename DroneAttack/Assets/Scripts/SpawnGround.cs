using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{

    public List<GameObject> groundPrefab;
    private Vector3 spawnPos = new Vector3(0, -22, 32);
    private int coutlevels = 10;
    private int currentGround = 0; // В "Game Manager"


    void Start()
    {
        SpawnGroundCount();
    }
    
    private void SpawnGroundCount()
    {
        Instantiate(groundPrefab[currentGround], spawnPos, groundPrefab[currentGround].transform.rotation);
    }

   
}


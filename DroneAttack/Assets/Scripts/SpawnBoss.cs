using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    
    public GameObject bossPrefab;
    private Vector3 spawnPosBos = new Vector3(0, 0, 45);
    private bool isBoss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inst();
    }

    public void Inst()
    {
        if (MoveDown.stopMove && isBoss == false)
        {
            Instantiate(bossPrefab, spawnPosBos, bossPrefab.transform.rotation);
            isBoss = true;
        }
    }
}

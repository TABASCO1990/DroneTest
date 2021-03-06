using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField] private List<GameObject> groundPrefab;
    [SerializeField] private List<GameObject> bossPrefab;
    private Vector3 positionGround = new Vector3(0, -22, 32);
    private Vector3 positionBoss = new Vector3(0, 0, 13);
    private int currentGround = 0;
    private int currentBoss = 0;
    private bool createBoss = true;
    private GameObject var;
    private int countGround=1;
    private int countRepeatGround = 3;
    void Start()
    {
        var = Instantiate(groundPrefab[currentGround], positionGround, groundPrefab[currentGround].transform.rotation);
    }

    void Update()
    {
       SpawnBoss();
       SpawnGround();
    }

    private void SpawnGround()
    {
        if (Enemy.isDeadBoss == true)
        {
            //countRepeatGround++;
            Destroy(var);
            MoveDown.isMove = true;
            createBoss = true;
            Enemy.isDeadBoss = false;
            if (groundPrefab.Count == currentGround + 1 && currentGround + 1 == countGround)
            {
                print("Конец");
            }
            else
            {
                countGround++;
                if (countGround <= countRepeatGround)
                {
                    var = Instantiate(groundPrefab[currentGround], positionGround,
                        groundPrefab[currentGround].transform.rotation);
                    
                }
                else
                {
                    countGround = 1;
                    currentGround++;
                    var = Instantiate(groundPrefab[currentGround], positionGround, groundPrefab[currentGround].transform.rotation);
                }
            }
        }
    }

    private void SpawnBoss()
    {
        if (MoveDown.isMove == false && createBoss)
        {
            Instantiate(bossPrefab[currentBoss], positionBoss, bossPrefab[currentBoss].transform.rotation);
            currentBoss++;
            createBoss = false;
        }
    }
}

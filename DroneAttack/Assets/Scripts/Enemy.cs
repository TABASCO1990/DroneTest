using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public static bool isDeadBoss;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Boss"))
        {
            health--;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                isDeadBoss = true;
                Destroy(gameObject);
            }
        }

    }
}

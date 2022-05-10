using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    Transform bulletSpawnPoint;
    void Start()
    {
        InvokeRepeating("BulletSpawn", 1.0f,0.1f);
        bulletSpawnPoint = GetComponent<Transform>();
    }

    private void BulletSpawn()
    {
        Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}

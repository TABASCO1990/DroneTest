using System.Collections;
using UnityEngine;

public class WavesSpawn : MonoBehaviour
{
    public GameObject[] wavesPrefabs;

    private void Start()
    {
        
        StartCoroutine(SpawnEnemies(wavesPrefabs.Length));
    }

    IEnumerator SpawnEnemies(int count)
    {
        yield return new WaitForSeconds(5);
        for (int i = 0; i < count; i++)
        {
            var a = Instantiate(wavesPrefabs[i], wavesPrefabs[i].transform.position, wavesPrefabs[i].transform.rotation);
            Destroy(a,7);
            yield return new WaitForSeconds(5);
        }
    }
    
}

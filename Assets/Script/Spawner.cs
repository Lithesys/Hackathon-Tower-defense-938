using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float spawnDelay = 1f;
    [SerializeField] GameObject[] enemyPrefab;
    [SerializeField] bool spawn = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnDelay);
        while (spawn)
        {
            yield return wait;
            int randomEnemy = Random.Range(0, enemyPrefab.Length);
            GameObject enemy = enemyPrefab[randomEnemy];
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public Transform[] spawnpoints = new Transform[22];
    public GameObject[] enemies = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnpoints.Length; i++)
        {
            int randomEnemyNumber = Random.Range(1, enemies.Length);
            GameObject enemy = Instantiate(enemies[randomEnemyNumber], spawnpoints[i].position, spawnpoints[i].rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

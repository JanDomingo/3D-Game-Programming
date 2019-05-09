using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    private float upperbound = 4.674f;
    private float lowerbound = -4.0f;

    public GameObject enemyPrefab;
    //public GameObject targetPreFab;

    public float spawnTimer = 2f;
    public float targetSpawnTimer = 4f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemies", spawnTimer);
    }

    // Update is called once per frame
    void SpawnEnemies()
    {
        float yPos = Random.Range(lowerbound, upperbound);
        Vector3 verticalSpawnPoint = transform.position;
        verticalSpawnPoint.y = yPos;

        Instantiate(enemyPrefab, verticalSpawnPoint, Quaternion.Euler(0f, 0f, 0f));
        Invoke("SpawnEnemies", spawnTimer);


        /*
            Instantiate(targetPreFab, verticalSpawnPoint, Quaternion.Euler(0f, 0f, 0f));
            Invoke("SpawnEnemies", targetSpawnTimer);
            */
    }
}

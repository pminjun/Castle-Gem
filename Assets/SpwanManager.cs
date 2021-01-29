using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public bool isSpawn = false;

    public float spawnDelay = 30f;
    float spawnTImer = 0f;

    public List<GameObject> spawnSpace1 = new List<GameObject>();
    public List<GameObject> spawnSpace2 = new List<GameObject>();
    public List<GameObject> spawnSpace3 = new List<GameObject>();
    public List<GameObject> spawnSpace4 = new List<GameObject>();
    int spawnIndex1;
    int spawnIndex2;
    int spawnIndex3;
    int spawnIndex4;

    void Start()
    {

    }

    void SpawnEnemy()
    {
        if (spawnTImer > spawnDelay)
        {
            spawnIndex1 = Random.Range(0, 3);
            Instantiate(enemy1, spawnSpace1[spawnIndex1].transform.position, Quaternion.identity);
            spawnIndex2 = Random.Range(0, 5);
            Instantiate(enemy2, spawnSpace2[spawnIndex2].transform.position, Quaternion.identity);
            spawnIndex3 = Random.Range(0, 3);
            Instantiate(enemy3, spawnSpace3[spawnIndex3].transform.position, Quaternion.identity);
            spawnIndex4 = Random.Range(0, 5);
            Instantiate(enemy4, spawnSpace4[spawnIndex4].transform.position, Quaternion.identity);

            spawnTImer = 0f;
        }
        else
        {
            spawnTImer += Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }
}

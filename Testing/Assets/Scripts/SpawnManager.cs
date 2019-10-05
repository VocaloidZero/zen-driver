using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] colorPrefabs;
    private float spawnRangeX = 10;
    private float spawnRangeZ = 2;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnColors", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void SpawnColors()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int colorIndex = Random.Range(0, colorPrefabs.Length);
        Instantiate(colorPrefabs[colorIndex], spawnPos, colorPrefabs[colorIndex].transform.rotation);
    }
}

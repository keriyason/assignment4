using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject catPrefab;
    public GameObject dogPrefab;
    public float spawnInterval = 1f; // Second in between each spawn
    public float xRange = 6f; // Horizontal spawn range
    public float spawnHeight = 6f; // Spawn above the player

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 1f, spawnInterval);
    }
    
    void SpawnObject()
    {
        GameObject prefabtoSpawn = Random.value > 0.5f ? catPrefab : dogPrefab;

        float xPos = Random.Range(-xRange, xRange);
        Vector2 spawnPos = new Vector2(xPos, spawnHeight);

        Instantiate(prefabtoSpawn, spawnPos, Quaternion.identity) ;

    }    
}

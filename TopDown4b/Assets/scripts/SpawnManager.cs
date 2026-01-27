using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemy;
    
    private GameObject player;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("SpawnEnemies", 3f, 3f);   
    }

    private void Update()
    {
        if (player != null) ;
    }

    void SpawnEnemies()
    {
        if (player != null)
        {
            int index = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[index].position, Quaternion.identity);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] //Makes the object accesible without makeing it public
    private GameObject enemyPrefab;

    [SerializeField]
    private float minimumSpawnTime;
    [SerializeField]
    private float maximumSpawnTime;

    private float timeUntilSpawn;



    // Start is called before the first frame update
    void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilSpawn -= Time.deltaTime; //Reduce the spawn by the amount of time passed by the frame

        if(timeUntilSpawn <= 0)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        timeUntilSpawn = Random.Range(minimumSpawnTime, maximumSpawnTime);
    }
}

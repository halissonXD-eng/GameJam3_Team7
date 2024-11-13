using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChameleon : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject pointSpawn;
 
    public float spawnInterval;
    
    void Start()
    {
        Invoke("SpawnChamel", spawnInterval);
    }

    void SpawnChamel ()
    {
        // Generate random ball index and random spawn position
        
        Vector3 spawnPos = pointSpawn.transform.position;
 
        Instantiate(Enemy, spawnPos, Enemy.transform.rotation);
        //Se agrega otra vez para repetir
        Invoke("SpawnChamel", spawnInterval);
    }
}

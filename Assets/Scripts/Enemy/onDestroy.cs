using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDestroy : MonoBehaviour
{
    public GameObject objectToSpawn; // El GameObject que quieres que aparezca
    public Transform spawnPoint; // El punto exacto donde quieres que aparezca el nuevo objeto

    void OnDestroy()
    {
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}

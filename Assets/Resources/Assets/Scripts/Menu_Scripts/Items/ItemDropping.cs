using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemDropping : MonoBehaviour
{
    private GameObject[] spawnPoints;
    private GameObject[] items;
    private float spawnTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawner");
        items = Resources.LoadAll<GameObject>("Assets/Resources/Assets/Prefabs/Menu_Prefabs");

        InvokeRepeating("SpawnRandom", spawnTime, spawnTime);
    }

    private void SpawnRandom()
    {
        foreach (var obj in spawnPoints)
            Debug.Log(obj.name);

        foreach (var obj in items)
            Debug.Log(obj.name);

        //GameObject sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        //GameObject i = items[Random.Range(0, items.Length)];

        //GameObject.Instantiate(i, sp.transform.position, Quaternion.identity);
    }
}

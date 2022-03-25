using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemDropping : MonoBehaviour
{
    private GameObject[] spawnPoints;
    private GameObject[] items;
    private float spawnTime = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawner");
        items = Resources.LoadAll<GameObject>("Menu_Prefabs").Cast<GameObject>().ToArray();


        InvokeRepeating("SpawnRandom", spawnTime, spawnTime);
    }

    private void SpawnRandom()
    {

        GameObject sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        GameObject i = items[Random.Range(0, items.Length)];

        GameObject.Instantiate(i, sp.transform.position, Quaternion.identity);
    }
}

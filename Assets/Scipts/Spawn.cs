using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //[Range(0,1)]
    public GameObject[] prefabs;

    public float initialDelay = 1f;
    public float enemyPeriod = 2f;

    void Start()
    {
        InvokeRepeating("CriarInimigo", initialDelay, enemyPeriod);
    }

    void CriarInimigo() //spawm do prefab
    {
        int prefabNum = Random.Range(0, 2);
        var prefab = prefabs[prefabNum];
        Vector3 spawnPosition = this.transform.position;
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}

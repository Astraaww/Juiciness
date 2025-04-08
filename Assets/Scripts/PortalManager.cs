using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float EnemyPeriod;

    public GameObject spawnVfx;
    void Start()
    {
        InvokeRepeating("InvokeEnemy", 0, EnemyPeriod);
    }

    void InvokeEnemy()
    {
        Instantiate(EnemyPrefab, transform.position, transform.rotation);
        Instantiate(spawnVfx, transform.position, transform.rotation);

    }
}
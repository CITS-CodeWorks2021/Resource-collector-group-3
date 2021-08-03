using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyClip : MonoBehaviour
{
    public ObjectPool moneySpawner;
    public float spawnDelay;
    float currentTimer = 0;
    public void ClickToSpawn()
    {
        moneySpawner.SpawnRandom(transform.position);
    }
}

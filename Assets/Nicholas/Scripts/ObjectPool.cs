using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public GameObject[] prefabsToPool;
    public int numToMake;

    public int NumSpawned
    {
        get
        {
            return activeObjects.Count;
        }
    }

    List<GameObject> inactiveObjects;
    List<GameObject> activeObjects;

    void Start()
    {
        inactiveObjects = new List<GameObject>();
        activeObjects = new List<GameObject>();

        // Build the Pooled Objects
        for (int i = 0; i < numToMake; i++)
        {
            foreach (GameObject g in prefabsToPool)
            {
                GameObject temp = Instantiate(g, transform.position, Quaternion.identity);
                temp.SetActive(false);
                inactiveObjects.Add(temp);
            }
        }

    }

    public GameObject SpawnRandom(Vector3 where)
    {
        int ranNum;
        GameObject objToReturn;
        if (inactiveObjects.Count != 0)
        {
            ranNum = Random.Range(0, inactiveObjects.Count);
            inactiveObjects[ranNum].transform.position = where;
            inactiveObjects[ranNum].SetActive(true);
            activeObjects.Add(inactiveObjects[ranNum]);
            objToReturn = inactiveObjects[ranNum];
            inactiveObjects.RemoveAt(ranNum);
        }
        else
        {
            ranNum = Random.Range(0, prefabsToPool.Length);
            objToReturn = Instantiate(prefabsToPool[ranNum], where, Quaternion.identity);
            inactiveObjects.Add(objToReturn);
        }
        objToReturn.GetComponent<Bill>().Spawn(this);
        return objToReturn;
    }

    public void RemoveOldest()
    {
        RemoveObject(0);
    }

    public void Reset()
    {
        int count = activeObjects.Count;
        for (int i = 0; i < count; i++)
        {
            RemoveObject(0);
        }
    }

    void RemoveObject(int which)
    {
        activeObjects[which].SetActive(false);
        inactiveObjects.Add(activeObjects[which]);
        activeObjects.RemoveAt(which);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bill : MonoBehaviour
{
    public ObjectPool myPool;
    public float moveSpeed, lifeTimer, xRange;
    private float currentTimer, xMove;
    public GameObject[] bonus;
    
    public void Spawn(ObjectPool pool)
    {
        myPool = pool;
        currentTimer = 0;
        xMove = Random.Range(-xRange, xRange);
        setFalse();
        switch (ScoreScript.bonusType) {
            case 0:
                bonus[0].SetActive(true);
                break;
            case 1:
                bonus[1].SetActive(true);
                bonus[0].SetActive(false);
                break;
            case 2:
                bonus[2].SetActive(true);
                break;
            case 3:
                bonus[3].SetActive(true);
                break;
            case 4:
                bonus[4].SetActive(true);
                break;
            case 5:
                bonus[5].SetActive(true);
                break;
            case 6:
                bonus[6].SetActive(true);
                break;
            case 7:
                bonus[7].SetActive(true);
                break;
            case 8:
                bonus[8].SetActive(true);
                break;
            case 9:
                bonus[9].SetActive(true);
                break;
            case 10:
                bonus[10].SetActive(true);
                break;
            case 11:
                bonus[11].SetActive(true);
                break;
        }
    }
    void setFalse()
    {
        
        bonus[1].SetActive(false);
        bonus[2].SetActive(false);
        bonus[3].SetActive(false);
        bonus[4].SetActive(false);
        bonus[5].SetActive(false);
        bonus[6].SetActive(false);
        bonus[7].SetActive(false);
        bonus[8].SetActive(false);
        bonus[9].SetActive(false);
        bonus[10].SetActive(false);
        bonus[11].SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (currentTimer < lifeTimer)
        {
            transform.Translate(xMove * Time.deltaTime, moveSpeed * Time.deltaTime, 0);
            currentTimer += Time.deltaTime;
        }
        else myPool.RemoveOldest();
    }
}

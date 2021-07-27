using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    public Text WorkerBeePriceText;
    public Text QualityPollenPriceText;
    int ScoreNum = 0;
    int workerBeePrice = 10;
    int qualityPollenPrice = 5;
    int numOfPressed;
    int addOn = 0;
    int holder = 0;

    private void Start()
    {
        MyscoreText.text = "" + ScoreNum;
        WorkerBeePriceText.text = "Price: $" + workerBeePrice;
        QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
    }

    public void clickScoreAdd()
    {
        ScoreNum += 1;
        MyscoreText.text = "" + ScoreNum;
    } 

    public void workerBees()
    {

        if(ScoreNum >= workerBeePrice && holder == 0)
        {
            ScoreNum -= 10;
            MyscoreText.text = "" + ScoreNum;
            workerBeePrice += 90;
            WorkerBeePriceText.text = "Price: $" + workerBeePrice;
            InvokeRepeating("workers", 1f, 1f);
            addOn += 1;
            holder += 1;
        }
            
        

        if (ScoreNum >= workerBeePrice && holder == 1)
        {
            ScoreNum -= 100;
            MyscoreText.text = "" + ScoreNum;
            workerBeePrice += 400;
            WorkerBeePriceText.text = "Price: $" + workerBeePrice;
            InvokeRepeating("workers", 1f, 1f);
            addOn += 1;
            holder += 1;
        }

        if (ScoreNum >= workerBeePrice && holder == 2)
        {
            ScoreNum -= 500;
            MyscoreText.text = "" + ScoreNum;
            WorkerBeePriceText.text = "Maxed";
            InvokeRepeating("workers", 1f, 1f);
            addOn += 1;
            holder += 1;
        }
        
    }

    public void workers()
    {
        ScoreNum += addOn;
        MyscoreText.text = "" + ScoreNum;
    }

    public void qualityPollen()
    {

    }
}

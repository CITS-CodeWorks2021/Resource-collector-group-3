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
    int addOn = 0;
    int holder = 0;
    int holdertwo = 0;
    int adding = 0;

    private void Start()
    {
        MyscoreText.text = "" + ScoreNum;
        WorkerBeePriceText.text = "Price: $" + workerBeePrice;
        QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
    }

    public void clickScoreAdd()
    {
        ScoreNum += 1 + adding;
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
        if (ScoreNum >= qualityPollenPrice && holdertwo == 0)
        {
            ScoreNum -= 5;
            MyscoreText.text = "" + ScoreNum;
            qualityPollenPrice += 45;
            QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
            adding += 1;
            holdertwo += 1;
        }

        if (ScoreNum >= qualityPollenPrice && holdertwo == 1)
        {
            ScoreNum -= 50;
            MyscoreText.text = "" + ScoreNum;
            qualityPollenPrice += 50;
            QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
            adding += 1;
            holdertwo += 1;
        }

        if (ScoreNum >= qualityPollenPrice && holdertwo == 2)
        {
            ScoreNum -= 100;
            MyscoreText.text = "" + ScoreNum;
            qualityPollenPrice += 100;
            QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
            adding += 1;
            holdertwo += 1;
        }

        if (ScoreNum >= qualityPollenPrice && holdertwo == 3)
        {
            ScoreNum -= 200;
            MyscoreText.text = "" + ScoreNum;
            qualityPollenPrice += 300;
            QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
            adding += 1;
            holdertwo += 1;
        }

        if (ScoreNum >= qualityPollenPrice && holdertwo == 4)
        {
            ScoreNum -= 500;
            MyscoreText.text = "" + ScoreNum;
            qualityPollenPrice += 0;
            QualityPollenPriceText.text = "Maxed";
            adding += 1;
            holdertwo += 1;

        }

    }
}

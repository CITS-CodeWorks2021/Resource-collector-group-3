using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    public Text WorkerBeePriceText;
    public Text QualityPollenPriceText;
    public Text BoostPriceText;
    public Text Currentx2Text;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public ParticleSystem sparks;
    int ScoreNum = 0;
    int workerBeePrice = 10;
    int qualityPollenPrice = 5;
    int currentx2Price = 500;
    int boostPrice = 50;
    int addOn = 1;
    int holder = 0;
    int holdertwo = 0;
    int holderthree = 0;
    int holderfour = 0;
    int adding = 1;
    float timer;
    private float startTime;
    public static int bonusType;

    private void Start()
    {
        MyscoreText.text = "" + ScoreNum;
        WorkerBeePriceText.text = "Price: $" + workerBeePrice;
        QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
        BoostPriceText.text = "Price: $" + boostPrice;
        Currentx2Text.text = "Price: $" + currentx2Price;
        startTime = Time.time;
    }

    private void Update()
    {
        float t = Time.time - startTime;

        timer = t / 60;
    }

    public void clickScoreAdd()
    {
        ScoreNum += adding;
        MyscoreText.text = "" + ScoreNum;
        
    } 

    public void Currentx2()
    {
        if(ScoreNum >= currentx2Price && holderfour == 0)
        {
            ScoreNum = ScoreNum * 2;
            MyscoreText.text = "" + ScoreNum;
            ScoreNum -= 500;
            MyscoreText.text = "" + ScoreNum;
            currentx2Price += 500;
            Currentx2Text.text = "Price: $" + currentx2Price;
            holderfour += 1;

        }
        if (ScoreNum >= currentx2Price && holderfour == 1)
        {
            ScoreNum = ScoreNum * 2;
            MyscoreText.text = "" + ScoreNum;
            ScoreNum -= 500;
            MyscoreText.text = "" + ScoreNum;
            currentx2Price += 500;
            Currentx2Text.text = "Price: $" + currentx2Price;
            holderfour += 1;

        }
        if (ScoreNum >= currentx2Price && holderfour == 2)
        {
            ScoreNum = ScoreNum * 2;
            MyscoreText.text = "" + ScoreNum;
            ScoreNum -= 500;
            MyscoreText.text = "" + ScoreNum;
            currentx2Price += 0;
            Currentx2Text.text = "Maxed";
            holderfour += 1;

        }
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
            addOn += 0;
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
            bonusType = 1;
        }

        if (ScoreNum >= qualityPollenPrice && holdertwo == 1)
        {
            ScoreNum -= 50;
            MyscoreText.text = "" + ScoreNum;
            qualityPollenPrice += 50;
            QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
            adding += 1;
            holdertwo += 1;
            bonusType = 2;
        }

        if (ScoreNum >= qualityPollenPrice && holdertwo == 2)
        {
            ScoreNum -= 100;
            MyscoreText.text = "" + ScoreNum;
            qualityPollenPrice += 100;
            QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
            adding += 1;
            holdertwo += 1;
            bonusType = 3;
        }

        if (ScoreNum >= qualityPollenPrice && holdertwo == 3)
        {
            ScoreNum -= 200;
            MyscoreText.text = "" + ScoreNum;
            qualityPollenPrice += 300;
            QualityPollenPriceText.text = "Price: $" + qualityPollenPrice;
            adding += 1;
            holdertwo += 1;
            bonusType = 4;
        }

        if (ScoreNum >= qualityPollenPrice && holdertwo == 4)
        {
            ScoreNum -= 500;
            MyscoreText.text = "" + ScoreNum;
            qualityPollenPrice += 0;
            QualityPollenPriceText.text = "Maxed";
            adding += 1;
            holdertwo += 1;
            bonusType = 5;

        }

    }

    void toggleActive(bool shouldActive)
    {
        Button1.SetActive(shouldActive);
        Button2.SetActive(shouldActive);
        Button3.SetActive(shouldActive);
        Button4.SetActive(shouldActive);
        WorkerBeePriceText.gameObject.SetActive(shouldActive);
        QualityPollenPriceText.gameObject.SetActive(shouldActive);
        BoostPriceText.gameObject.SetActive(shouldActive);
        Currentx2Text.gameObject.SetActive(shouldActive);
    }

    public void Boost()
    {
        if (ScoreNum >= boostPrice && holderthree == 0)
        {
            ScoreNum -= 50;
            MyscoreText.text = "" + ScoreNum;
            boostPrice += 100;
            BoostPriceText.text = "Price: $" + boostPrice;
            holderthree += 1;

            addOn *= 2;
            adding *= 2;
            bonusType = adding-1;
            toggleActive(false);
            InvokeRepeating("nonBoost", 15f, 1f);

        }

        if (ScoreNum >= boostPrice && holderthree == 1)
        {
            ScoreNum -= 150;
            MyscoreText.text = "" + ScoreNum;
            boostPrice += 150;
            BoostPriceText.text = "Price: $" + boostPrice;
            holderthree += 1;

            addOn *= 2;
            adding *= 2;
            bonusType = adding-1;
            toggleActive(false);


            InvokeRepeating("nonBoost", 15f, 1f);
        }

        if (ScoreNum >= boostPrice && holderthree == 2)
        {
            ScoreNum -= 300;
            MyscoreText.text = "" + ScoreNum;
            boostPrice += 200;
            BoostPriceText.text = "Price: $" + boostPrice;
            holderthree += 1;

            addOn *= 2;
            adding *= 2;
            bonusType = adding-1;
            toggleActive(false);
            InvokeRepeating("nonBoost", 15f, 1f);
        }

        if (ScoreNum >= boostPrice && holderthree == 3)
        {
            ScoreNum -= 500;
            MyscoreText.text = "" + ScoreNum;
            BoostPriceText.text = "Maximum Used";
            holderthree += 1;

            addOn *= 2;
            adding *= 2;
            bonusType = adding-1;
            toggleActive(false);
            InvokeRepeating("nonBoost", 15f, 1f);
        }


    }

    public void nonBoost()
    {
        resetDisplay();
        addOn /= 2;
        adding /= 2;
        MyscoreText.text = "" + ScoreNum;
        toggleActive(true);

        CancelInvoke("nonBoost");

    }

    public void resetDisplay()
    {
        if (bonusType == 1)
        {
            bonusType = 0;
        }
        if (bonusType == 3)
        {
            bonusType = 1;
        }
        if (bonusType == 5)
        {
            bonusType = 2;
        }
        if (bonusType == 7)
        {
            bonusType = 3;
        }
        if (bonusType == 9)
        {
            bonusType = 4;
        }
        if (bonusType == 11)
        {
            bonusType = 5;
        }
    }
}

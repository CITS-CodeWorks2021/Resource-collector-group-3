using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    int ScoreNum = 0;

    private void Start()
    {
        MyscoreText.text = "" + ScoreNum;

    }

    public void clickScoreAdd()
    {
        ScoreNum += 1;
        MyscoreText.text = "" + ScoreNum;
    } 
}

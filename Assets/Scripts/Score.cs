using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int currenAmount;

    public void ModifyScore(int amount)
    {
        currenAmount += amount;
        UpdateScoreDisplay(currenAmount);
    }
    public void UpdateScoreDisplay(int score)
    {
        scoreText.text = "Score :" + score;
    }

}

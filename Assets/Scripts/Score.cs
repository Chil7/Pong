using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int currenAmount;

    public static Score instance;

    private void Awake()
    {
        //if (instance == null)
        //    instance = this;
        //else
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        //DontDestroyOnLoad(gameObject);
    }

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

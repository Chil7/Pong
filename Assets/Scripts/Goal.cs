using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    private Score score;
    private bool isGoal;

    private void Awake()
    {
        score = FindObjectOfType<Score>();
    }

    private void Start()
    {
        isGoal = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            isGoal = true;

            if (isGoal == true)
            {
                score.ModifyScore(1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

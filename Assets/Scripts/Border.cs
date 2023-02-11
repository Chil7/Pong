using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    private bool isBump = false;
    private Ball ball;

    private void Awake()
    {
        ball = FindObjectOfType<Ball>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (!isBump)
            {
                ball.ballSpeed += 1f;
                isBump = true;
                Invoke("Refresh", 1f);
            }
        }
    }

    private void Refresh()
    {
        isBump = false;
    }
}

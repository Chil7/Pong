using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector]
    public float playerSpeed;

    void Start()
    {
        playerSpeed = 10f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate (0f, Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime, 0f);
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime, 0f);
        }
    }
}

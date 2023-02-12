using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    [HideInInspector]
    public float playerSpeed;

    void Start()
    {
        playerSpeed = 10f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.Translate(0f, Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime, 0f);
            transform.position += transform.up * playerSpeed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.Translate(0f, Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime, 0f);
            transform.position += -transform.up * playerSpeed * Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    [SerializeField] private Text goalText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Destroy(other.gameObject);
        }
    }
}

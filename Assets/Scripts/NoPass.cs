using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPass : MonoBehaviour
{
    public Score score;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            score.score -= 20f;
        }
    }
}
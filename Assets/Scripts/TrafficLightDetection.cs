using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightDetection : MonoBehaviour
{
    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;
    public Score score;
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player") && redLight.activeSelf == true)
        {
            score.score -= 10f;
        }
        if (other.CompareTag("Player") && yellowLight.activeSelf == true)
        {
            score.score -= 10f;
        }
        if (other.CompareTag("Player") && greenLight.activeSelf == true)
        {
            score.score += 10f;
        }
    }
}

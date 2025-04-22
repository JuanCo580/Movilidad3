using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDetection : MonoBehaviour
{
    public bool detection, validation;
    public float t, tMax = 8f;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(detection == true)
        {
            t += Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            detection = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && t < tMax)
        {
            score.score -= 10f;
        }
        else if (other.CompareTag("Player") && t > tMax)
        {
            score.score += 10f;
        }
        t = 0;
        detection = false;
        validation = false;
    }
}

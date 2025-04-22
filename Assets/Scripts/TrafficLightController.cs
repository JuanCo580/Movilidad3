using System.Collections;
using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;

    public float redDuration = 5f;
    public float yellowDuration = 2f;
    public float greenDuration = 5f;

    private void Start()
    {
        StartCoroutine(TrafficLightSequence());
    }

    private IEnumerator TrafficLightSequence()
    {
        while (true)
        {
            // Red light
            redLight.SetActive(true);
            yellowLight.SetActive(false);
            greenLight.SetActive(false);
            yield return new WaitForSeconds(redDuration);

            // Green light
            redLight.SetActive(false);
            yellowLight.SetActive(false);
            greenLight.SetActive(true);
            yield return new WaitForSeconds(greenDuration);

            // Yellow light
            redLight.SetActive(false);
            yellowLight.SetActive(true);
            greenLight.SetActive(false);
            yield return new WaitForSeconds(yellowDuration);
        }
    }
}

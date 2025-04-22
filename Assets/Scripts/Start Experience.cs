using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExperience : MonoBehaviour
{
    public GameObject barrier, arrows;
    public Cronometro crono;
    private void OnTriggerEnter(Collider other)
    {
        barrier.SetActive(false);
        arrows.SetActive(true);
        crono.enabled = true;
    }
}

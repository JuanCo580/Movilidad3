using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fINALdETECTION : MonoBehaviour
{
    public GameObject lastArrows, barriers, final;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            lastArrows.SetActive(true);
            barriers.SetActive(false);
            final.SetActive(true);
        }
    }
}

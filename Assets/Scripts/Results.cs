using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Results : MonoBehaviour
{
    public GameObject resultsGameObject, level;
    public Cronometro crono;
    private void OnTriggerExit(Collider other)
    {
        resultsGameObject.SetActive(true);
        //level.SetActive(false);
        crono.enabled = false;
    }
}

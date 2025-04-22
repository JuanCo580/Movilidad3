using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySignal : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

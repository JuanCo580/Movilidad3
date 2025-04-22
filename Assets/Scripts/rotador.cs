using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotador : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    void Update()
    {
        transform.Rotate(x, y, z);
    }
}

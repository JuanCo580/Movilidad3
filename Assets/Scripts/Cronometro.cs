using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public float timer = 0;
    public int minutes, seconds;
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0) timer = 0;
        minutes = (int)(timer / 60f);
        seconds = (int)(timer - minutes * 60f);
        texto.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        //if (timer == 0) Destroy(this);
    }
}

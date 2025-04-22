using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emisivoSiPuede : MonoBehaviour
{
    //public Material material;
    public SpriteRenderer m_SpriteRenderer;
    public Color color;
    public Color color2;
    public float timeElapsed = 0f;
    public float colorChangeSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        color = m_SpriteRenderer.color;
        color2 = m_SpriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime * colorChangeSpeed;
        float hue = Mathf.Sin(timeElapsed) * 0.5f + 0.5f;
        color2 = Color.HSVToRGB(1f, hue, 1f);
        m_SpriteRenderer.color = color2;
    }

}

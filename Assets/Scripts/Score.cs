using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float score = 0;
    public TextMeshProUGUI textMeshPro;
    void Update()
    {
        textMeshPro.text = score.ToString();
    }
}
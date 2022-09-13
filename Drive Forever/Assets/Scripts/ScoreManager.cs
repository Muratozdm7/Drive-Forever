using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text skorText;
    public static float skor;

    
    void Start()
    {
        skor = 0;
    }

    
    void Update()
    {
        skorText.text = skor.ToString();
    }
}

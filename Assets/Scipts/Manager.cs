using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public TextMeshProUGUI counterText;
    private int counter = 0;

    void Start()
    {
        instance = this;
        UpdateCounterText();
    }

    void UpdateCounterText()
    {
        counterText.text = "Contador: " + counter.ToString();
    }

    
    public void IncreaseCounter()
    {
        counter++;
        UpdateCounterText(); 
    }
}

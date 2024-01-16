using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperaturePlayer;
    public TextMeshProUGUI temperatureText;

    public void UpdateTemperatureText()
    {
        float roundedTemperature = Mathf.Round(temperaturePlayer.temperatureCurrent * 10.0f) * 0.1f;
        string temperatureString = roundedTemperature.ToString();
        temperatureText.text = temperatureString;
    }

    void Update()
    {
        UpdateTemperatureText();
    }
}

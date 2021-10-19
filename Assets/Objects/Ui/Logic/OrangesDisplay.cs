using System;
using TMPro;
using UnityEngine;

public class OrangesDisplay : MonoBehaviour
{
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        var gatherer = FindObjectOfType<Gatherer>();
        gatherer.OnOrangeFound += UpdateDisplay;
        UpdateDisplay(gatherer.Oranges);
    }

    private void UpdateDisplay(Proportion proportion)
    {
        text.text = proportion.ToString();
    }
}

using System;
using TMPro;
using UnityEngine;

public class LevelNameDisplay : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<TextMeshProUGUI>().text = FindObjectOfType<Level>().Name;
    }
}

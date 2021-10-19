using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScaler : MonoBehaviour
{
    void Start()
    {
        float height = (gameObject.GetComponent<RectTransform>().rect.height/3) - 30;
        gameObject.GetComponent<UnityEngine.UI.GridLayoutGroup>().cellSize = new Vector2(height, height);
    }
}
using UnityEngine;

public class RedsDisplay : MonoBehaviour
{
    private void Awake()
    {
        var gatherer = FindObjectOfType<Gatherer>();
        gatherer.OnRedFound += Show;
        gameObject.SetActive(false);
    }

    private void Show(Proportion proportion)
    {
        if (proportion.IsEmpty == false)
            gameObject.SetActive(true);
    }
}

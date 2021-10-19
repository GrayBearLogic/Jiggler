using System;
using UnityEngine;

public class Gatherer : MonoBehaviour
{
    public event Action<Proportion> OnOrangeFound;
    public event Action<Proportion> OnRedFound;
    
    public Proportion Oranges { get; private set; }
    public Proportion Reds { get; private set; }

    private void Awake()
    {
        Oranges = new Proportion(FindObjectsOfType<Orange>().Length);
        Reds = new Proportion(FindObjectsOfType<Red>().Length);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<Orange>(out var orange))
        {
            orange.BePicked();
            Oranges.AddOne();
            OnOrangeFound?.Invoke(Oranges);
        }
        else if (other.gameObject.TryGetComponent<Red>(out var red))
        {
            red.BePicked();
            Reds.AddOne();
            OnRedFound?.Invoke(Reds);
        }
    }
}
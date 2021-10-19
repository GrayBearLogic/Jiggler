using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action OnDestinationReached;
    public event Action OnDeath;

    public bool IsAlive { get; private set; } = true;

    public void RichDestination()
    {
        Destroy(GetComponent<Pusher>());
        OnDestinationReached?.Invoke();
        Destroy(this);
    }

    public void Die()
    {
        Destroy(GetComponent<Collider2D>());
        IsAlive = false;
        OnDeath?.Invoke();
    }
}

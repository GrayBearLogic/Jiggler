using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    private Player target;
    private bool attached = true;

    private void Awake()
    {
        target = FindObjectOfType<Player>();
        target.OnDeath += Detach;
        target.OnDestinationReached += Detach;
    }

    private void Detach()
    {
        attached = false;
    }

    private void Update()
    {
        if (attached)
        {
            transform.position = target.transform.position + Vector3.back * 10;
        }
    }
}

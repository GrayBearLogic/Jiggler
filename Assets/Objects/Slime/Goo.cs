using UnityEngine;

public class Goo : MonoBehaviour
{
    private ParticleSystem ps;
    private void Awake()
    {
        ps = GetComponent<ParticleSystem>();
        var pusher = GetComponentInParent<Pusher>();
        pusher.OnCollide += DropGoo;
    }

    private void DropGoo()
    {
        ps.Play();
    }
}

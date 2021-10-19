using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Rigidbody2D rb;
    private Pusher pusher;

    private void Awake()
    {
        pusher = GetComponentInParent<Pusher>();
        rb = GetComponentInParent<Rigidbody2D>();
    }

    private void Update()
    {
        var stVector = pusher.InContact ? pusher.ContactDir : rb.velocity;
        transform.rotation = Quaternion.FromToRotation(Vector2.up, stVector.normalized);
    }
    
}

using UnityEngine;

public class Stretcher : MonoBehaviour
{
    [SerializeField] private float stretchingFactor = 0.1f;

    private Rigidbody2D rb;
    private Pusher pusher;

    private void Awake()
    {
        pusher = GetComponentInParent<Pusher>();
        rb = GetComponentInParent<Rigidbody2D>();
    }

    private void Update()
    {
        if (pusher.InContact == false)
        {
            var stValue = 1 + rb.velocity.magnitude * stretchingFactor;
            transform.localScale = new Vector3(1f / stValue, 1f * stValue, 1f);
        }
        else
        {
            transform.localScale = Vector3.one;
        }
    }
    
}

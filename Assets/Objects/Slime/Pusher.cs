using System;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    public event Action OnCollide;
    public event Action OnDetach;
    public event Action OnPush; 
    
    [SerializeField] private float forceFactor = 1f;
    [SerializeField] private float pendulumFrequency = 1f;
    [SerializeField] private float pendulumAmplitude = 80f;

    private Rigidbody2D rb;
    private AudioSource audioSource;

    public bool InContact
    {
        get;
        private set;
    }
    public Vector2 ContactDir
    {
        get;
        private set;
    }
    public Vector2 Direction
    {
        get
        {
            var harmonicValue = Mathf.Cos(Time.time * pendulumFrequency) * pendulumAmplitude;
            var rotation = Quaternion.Euler(0, 0, harmonicValue);
            return rotation * ContactDir.normalized;
        }
    }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.anyKey && InContact)
        {
            rb.AddForce(Direction * forceFactor);
            OnPush?.Invoke();
            InContact = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.gravityScale = 0;
        rb.drag = 2;

        ContactDir = collision.GetContact(0).normal;
        InContact = true;
        OnCollide?.Invoke();
        audioSource.Play();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        rb.gravityScale = 1;
        rb.drag = 0;

        InContact = false;
        OnDetach?.Invoke();
    }
    
}
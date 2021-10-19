using UnityEngine;

public class Orange : MonoBehaviour
{
    public void BePicked()
    {
        GetComponentInParent<AudioSource>().Play();
        Destroy(gameObject);
    }
}

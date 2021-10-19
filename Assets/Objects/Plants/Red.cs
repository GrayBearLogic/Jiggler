using UnityEngine;

public class Red : MonoBehaviour
{
    public void BePicked()
    {
        GetComponentInParent<AudioSource>().Play();
        Destroy(gameObject);
    }
}

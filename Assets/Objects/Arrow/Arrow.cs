using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Pusher driver;

    private void Awake()
    {
        driver = GetComponentInParent<Pusher>();
        driver.OnDetach += Hide;
        driver.OnCollide += Show;
        driver.OnPush += Hide;
        
        gameObject.SetActive(false);
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.rotation = Quaternion.FromToRotation(Vector2.up, driver.Direction);
    }
}

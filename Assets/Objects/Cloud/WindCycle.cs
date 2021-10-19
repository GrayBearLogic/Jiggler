using UnityEngine;

public class WindCycle : MonoBehaviour
{
    public float speed = 1f;
    public float bounding;
    private void Update()
    {
        transform.Translate(Vector3.left * (speed * Time.deltaTime));
        if (transform.position.x < -bounding)
        {
            transform.Translate(Vector3.right * (2 * bounding));
        }
    }
}

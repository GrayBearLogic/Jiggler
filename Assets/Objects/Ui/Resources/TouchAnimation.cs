using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class TouchAnimation : MonoBehaviour
{
    [SerializeField] private float duration = 1f;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void StartAnimation()
    {
        StartCoroutine(Animation());
    }

    private IEnumerator Animation()
    {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pos.x, pos.y, 0);
        
        for (var time = 0f; time < duration; time += Time.deltaTime)
        {
            var progress = time / duration;
            transform.localScale = Vector3.one * Mathf.Lerp(1f, 50f, progress);
            image.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, progress));

            yield return null;
        }
        
    }
}

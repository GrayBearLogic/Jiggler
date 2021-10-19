using UnityEngine;
using UnityEngine.UI;

public class MenuSwitcher : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector2 vector;
    private Vector2 resolutionX;
    private bool moved = false;
    private Vector2 startPoint;


    private void Awake()
    {
        resolutionX = transform.parent.GetComponent<CanvasScaler>().referenceResolution;

    }

    public void SwitchToLeft()
    {
        startPoint = GetComponent<RectTransform>().anchoredPosition;
        vector = Vector2.right;
        moved = true;
    }
    public void SwitchToRight()
    {
        startPoint = GetComponent<RectTransform>().anchoredPosition;
        vector = Vector2.left;
        moved = true;
    }

    private void Update()
    {
        if (!moved) return;
        Vector2 target = startPoint + vector * resolutionX;

        GetComponent<RectTransform>().anchoredPosition = Vector2.MoveTowards(
            GetComponent<RectTransform>().anchoredPosition, target, speed * Time.deltaTime);

        if (GetComponent<RectTransform>().anchoredPosition == target)
            moved = false;
    }
}
using UnityEngine;
using Animation = AnimateUi.Animation;

public class Star : MonoBehaviour
{
    [SerializeField] private Color activecolor = Color.yellow;

    public Animation GetActivationAnimation()
    {
        return Animation.For(gameObject).SetColor(activecolor);
    }
}

using UnityEngine;
using Animation = AnimateUi.Animation;

public class Message : MonoBehaviour
{
    
    public Animation Show
    {
        get => Animation.For(gameObject)
            .SetPositon(Vector2.up * 1000f)
            .Show()
            .Move(Vector2.down * 1000f, 0.5f)
        ;
    }
    
    public Animation Hide
    {
        get => Animation.For(gameObject)
            .Move(Vector2.up * 1000f, 0.5f)
        ;
    }
    
}

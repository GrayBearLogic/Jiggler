using UnityEngine;
using Animation = AnimateUi.Animation;

public class RadioIndicator : MonoBehaviour
{
    [SerializeField] private GameObject rotor;
    
    public Animation TurnOn
    {
        get => Animation.For(rotor).Scale(10f, 0.3f);
    }

    public Animation TurnOff
    {
        get => Animation.For(rotor).SetScale(0.1f);
    }
}

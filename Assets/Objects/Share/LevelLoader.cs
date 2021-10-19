using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private Transform slime;
    [Space]
    [SerializeField] private Level defaultLevel;
    [SerializeField] private Skin defaultSkin;
    
    private void Awake()
    {
        Instantiate(GameData.Player ?? defaultSkin, slime);
        Instantiate(GameData.Level  ?? defaultLevel);
    }
}
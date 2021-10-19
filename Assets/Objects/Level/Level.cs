using System;
using UnityEngine;

public class Level : MonoBehaviour
{
    public event Action<LevelInfo> OnVictory;
    public event Action OnDefeat;
    
    [SerializeField] private string levelName;
    [SerializeField] private int index;

    public int CompletionLevel
    {
        get => PlayerPrefs.GetInt(index.ToString());
        private set => PlayerPrefs.SetInt(index.ToString(), value);
    }
    public int Index
    {
        get => index;
    }
    public string Name
    {
        get => levelName;
    }

    private void Start()
    {
        var player = FindObjectOfType<Player>();
        player.OnDeath += LooseGame;
        player.OnDestinationReached += WinGame;
    }

    private void WinGame()
    {
        var gatherer = FindObjectOfType<Gatherer>();
        
        var completion = 1;
        if (gatherer.Oranges.IsFull)
            completion++;
        if (gatherer.Reds.IsFull)
            completion++;

        CompletionLevel = completion;
        IncreaseMaxLevel(index);
        PlayerPrefs.Save();

        OnVictory?.Invoke(new LevelInfo(Name, completion, gatherer.Oranges, gatherer.Reds));
    }

    private void IncreaseMaxLevel(int i)
    {
        var oldMaxLevel = PlayerPrefs.GetInt(Constants.LastLevel);
        PlayerPrefs.SetInt(Constants.LastLevel, Math.Max(oldMaxLevel, index));
    }

    private void LooseGame()
    {
        OnDefeat?.Invoke();
    }
}
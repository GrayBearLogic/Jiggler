using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Animation = AnimateUi.Animation;

public class VictoryMessage : MonoBehaviour
{
    [SerializeField] private Star[] stars;
    [Header("Labels")]
    [SerializeField] private GameObject levelTitle;
    [Space(5f)]
    [SerializeField] private GameObject orangesCounter;
    [SerializeField] private GameObject redsCounter;
    [Header("Buttons")]
    [SerializeField] private Button homeButton;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button nextButton;

    private void Awake()
    {
        var level = FindObjectOfType<Level>();
        level.OnVictory += Show;
        
        homeButton.onClick.AddListener(GoToMenu);
        restartButton.onClick.AddListener(Restart);
        nextButton.onClick.AddListener(NextLevel);
        
        gameObject.SetActive(false);
    }

    private void NextLevel()
    {
        throw new NotImplementedException();
    }

    private void Restart()
    {
        SceneManager.LoadSceneAsync("Serhiy");
    }

    private static void GoToMenu()
    {
        SceneManager.LoadSceneAsync("ArturMenu");
    }

    private void Show(LevelInfo data)
    {
        var animation =
            Animation
                .For(gameObject)
                .SetPositon(Vector2.up * 1000f)
                .Show()
                .Then(Animation.For(orangesCounter).SetText(data.Oranges.ToString()))
                .Then(Animation.For(redsCounter).SetText(data.Reds.ToString()))
                .Then(Animation.For(levelTitle).SetText($"Level {data.LevelName}"))
                .Move(Vector2.down * 1000f, 0.1f)
                .Wait(0.2f)
            ;

        for (var i = 0; i < data.Completion; i++)
            animation =
                animation
                    .Wait(0.3f)
                    .Then(stars[i].GetActivationAnimation());
        
        animation.Run();
    }
}

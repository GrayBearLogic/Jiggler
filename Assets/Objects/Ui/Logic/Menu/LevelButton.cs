using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private Sprite enable;
    [SerializeField] private Sprite disable;
    [SerializeField] private GameObject[] radios;

    public bool Interactable
    {
        set => GetComponent<Button>().interactable = value;
    }
    
    public void Init(Level levelAsset)
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            GameData.Level = levelAsset;
            SceneManager.LoadSceneAsync(Constants.LevelScene);
            //SceneManager.LoadSceneAsync(levelAsset.Name);
        });
        GetComponentInChildren<TextMeshProUGUI>().text = levelAsset.Name;

        for (int i = 0; i < levelAsset.CompletionLevel; i++)
        {
            radios[i].GetComponent<Image>().sprite = enable;
        }
    }
}

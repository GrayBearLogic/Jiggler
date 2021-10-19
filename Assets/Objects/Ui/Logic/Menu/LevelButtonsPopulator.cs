using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Linq;

public class LevelButtonsPopulator : MonoBehaviour
{
    [SerializeField] private AssetLabelReference label;
    [SerializeField] private GameObject panelPrefab;
    [SerializeField] private LevelButton buttonPrefab;

    private Transform container;
    private Level[] levels;
    private void Awake()
    {
        StartCoroutine(LoadLevels());
    }
    private IEnumerator LoadLevels()
    {
        var prefabs = new ConcurrentBag<GameObject>();
        var task = Addressables.LoadAssetsAsync<GameObject>(label, o => prefabs.Add(o));
        yield return new WaitUntil(() => task.IsDone);
        levels = prefabs.Select(x => x.GetComponent<Level>()).ToArray();
        Populate(levels);
    }
    public void Populate(IEnumerable<Level> levels)
    {
        levels = levels.OrderBy(o => o.Index);
        
        for (int i = 0; i < levels.Count(); i++)
        {
            if (i % 15 == 0)
            {
                GameObject panel = Instantiate(panelPrefab, transform);
                container = panel.transform;
            }

            LevelButton button = Instantiate(buttonPrefab, container.transform);
            button.Init(levels.ElementAt(i));

            if (i > 0)
                if (levels.ElementAt(i - 1).CompletionLevel == 0)
                    button.Interactable = false;
        }
    }
}
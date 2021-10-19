using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Level levelAsset;

    public void Do()
    {
        GameData.Level = levelAsset;
        SceneManager.LoadScene(0);
    }
}

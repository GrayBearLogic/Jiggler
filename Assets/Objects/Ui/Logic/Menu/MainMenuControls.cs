using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Serhiy");
    }
    public void ExitPressed()
    {
        Application.Quit();
    }

}

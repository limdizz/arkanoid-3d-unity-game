using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayLevel1Button()
    {
        SceneManager.LoadScene(1);
    }

    public void OnPlayLevel2Button()
    {
        SceneManager.LoadScene(4);
    }

    public void OnPlayLevelMenuButton()
    {
        SceneManager.LoadScene(5);
    }
    public void OnMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}

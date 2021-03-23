using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuittoMainMenu : MonoBehaviour
{
    
    private string sceneName = "Main Menu";

    public void quitToMenu()
    {
        SceneManager.LoadScene(sceneName);
    }
}

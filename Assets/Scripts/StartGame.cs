using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   private string sceneName = "Level 1 (Luthier)";
    
   public void LoadLevelOne()
    {
        SceneManager.LoadScene(sceneName);
    }
}

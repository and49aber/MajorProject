using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigame : MonoBehaviour
{

    [SerializeField] private GameObject miniGame;


    //starts the minigame
    public void StartMiniGame()
    {
        miniGame.SetActive(true);
    }

    //ends the minigame
    public void EndMiniGame()
    {
        miniGame.SetActive(false);
    }
}

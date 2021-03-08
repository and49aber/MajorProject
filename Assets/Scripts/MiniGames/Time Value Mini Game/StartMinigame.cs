using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigame : MonoBehaviour
{

    [SerializeField] private GameObject tValueGame;


    //starts the minigame
    public void StartTimeValueGame()
    {
        tValueGame.SetActive(true);
    }

    //ends the minigame
    public void EndTimeValueGame()
    {
        tValueGame.SetActive(false);
    }
}

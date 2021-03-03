using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigame : MonoBehaviour
{

    [SerializeField] private GameObject tValueGame;

    public void StartTimeValueGame()
    {
        tValueGame.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFunctions : MonoBehaviour
{
    [SerializeField] private GameObject tutorialCan;
    [SerializeField] private GameObject welcomeCan;
    [SerializeField] private GameObject timeValueCan;

    public void tutorialCanvas()
    {
        tutorialCan.SetActive(true);
        welcomeCan.SetActive(false);
        timeValueCan.SetActive(false);
    }

    public void returnToWelcomeMenu()
    {
        welcomeCan.SetActive(true);
        tutorialCan.SetActive(false);
    }

    public void timeValueCanvas()
    {
        timeValueCan.SetActive(true);
        tutorialCan.SetActive(false);
    }

}

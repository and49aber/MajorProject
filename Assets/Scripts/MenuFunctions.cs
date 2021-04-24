using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFunctions : MonoBehaviour
{
    [SerializeField] private GameObject tutorialCan;
    [SerializeField] private GameObject welcomeCan;
    [SerializeField] private GameObject timeValueCan;
    [SerializeField] private GameObject notationCan;
    [SerializeField] private GameObject musicalTermsCan;
    [SerializeField] private GameObject aimOfGameCan;

    public void tutorialCanvas()
    {
        tutorialCan.SetActive(true);
        welcomeCan.SetActive(false);
        timeValueCan.SetActive(false);
        notationCan.SetActive(false);
        musicalTermsCan.SetActive(false);
        aimOfGameCan.SetActive(false);
       
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
    public void notationCanvas()
    {
        notationCan.SetActive(true);
        tutorialCan.SetActive(false);
    }

    public void musicalTermsCanvas()
    {

        tutorialCan.SetActive(false);
        musicalTermsCan.SetActive(true);
    }


    public void aimOfGameCanvas()
    {
        welcomeCan.SetActive(false);
        aimOfGameCan.SetActive(true);
    }

}

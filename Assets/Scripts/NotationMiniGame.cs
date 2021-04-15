using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NotationMiniGame : StartMinigame
{
    [SerializeField] private GameObject Enote;
    [SerializeField] private GameObject Fnote;
    [SerializeField] private GameObject Gnote;
    [SerializeField] private GameObject Anote;
    [SerializeField] private GameObject Bnote;
    [SerializeField] private GameObject Cnote;
    [SerializeField] private GameObject Dnote;
    private string correctAnswer;
    private int correctQuestions = 0;
    [SerializeField] private TextMeshProUGUI textBoxAnswers;
    [SerializeField] private TMP_InputField inputAnswer;
    [SerializeField] private string dialogueIncorrect;
    [SerializeField] private string dialogueCorrect;
    private DialogueManager diaManager;
    [SerializeField] private Button startChallengeButton;
    [SerializeField] private Button endChallengeButton;
    public static bool canAllegro;


    private void Start()
    {
        diaManager = FindObjectOfType<DialogueManager>();
        createNotationMiniGame();
        
    }

    private void Update()
    {
        textBoxAnswers.text = correctQuestions.ToString();
    }

    public void confirmAnswer()
    {
        string userAnswer = GameObject.Find("InputField").GetComponent<TMP_InputField>().text.ToString().ToUpper();
        if (userAnswer == correctAnswer.ToString())
        {
            correctQuestions++;
            resetNotationGame();
            createNotationMiniGame();
            GameObject.Find("InputField").GetComponent<TMP_InputField>().text = "";
            if (correctQuestions == 5)
            {
                EndMiniGame();
                diaManager.ShowDialogue(dialogueCorrect);
                startChallengeButton.gameObject.SetActive(false);
                endChallengeButton.gameObject.SetActive(false);
                canAllegro = true;
            }

        }
        else
        {
            GameObject.Find("InputField").GetComponent<TMP_InputField>().text = "";
            EndMiniGame();
            correctQuestions = 0;
            resetNotationGame();
            createNotationMiniGame();
            diaManager.ShowDialogue(dialogueIncorrect);
        }


    }

    private void createNotationMiniGame()
    {
        resetNotationGame();
       
        int noteShown = Random.Range(1, 8);
        switch (noteShown)
        {
            case 1:
                Enote.SetActive(true);
                correctAnswer = "E";
                return;

            case 2:
                Fnote.SetActive(true);
                correctAnswer = "F";
                return;
            case 3:
                Gnote.SetActive(true);
                correctAnswer = "G";
                return;
            case 4:
                Anote.SetActive(true);
                correctAnswer = "A";
                return;
            case 5:
                Bnote.SetActive(true);
                correctAnswer = "B";
                return;
            case 6:
                Cnote.SetActive(true);
                correctAnswer = "C";
                return;
            case 7:
                Dnote.SetActive(true);
                correctAnswer = "D";
                return;
        }
            
    }

    private void resetNotationGame()
    {
        Enote.SetActive(false);
        Fnote.SetActive(false);
        Gnote.SetActive(false);
        Anote.SetActive(false);
        Bnote.SetActive(false);
        Cnote.SetActive(false);
        Dnote.SetActive(false);

    }

}

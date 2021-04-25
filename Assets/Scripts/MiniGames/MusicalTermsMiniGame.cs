using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MusicalTermsMiniGame : StartMinigame
{
    [SerializeField] string[] possibleAnswers; 
    [SerializeField] GameObject answerButton1;
    [SerializeField] GameObject answerButton2;
    [SerializeField] GameObject answerButton3;
    [SerializeField] GameObject answerButton4;
    [SerializeField] TextMeshProUGUI answerButton1Text;
    [SerializeField] TextMeshProUGUI answerButton2Text;
    [SerializeField] TextMeshProUGUI answerButton3Text;
    [SerializeField] TextMeshProUGUI answerButton4Text;
    [SerializeField] TextMeshProUGUI question;
    [SerializeField] private TextMeshProUGUI textBoxAnswers;
    private string correctAnswer;
    private int correctQuestions = 0;
    [SerializeField] private string dialogueIncorrect;
    [SerializeField] private string dialogueCorrect;
    private DialogueManager diaManager;
    [SerializeField] private Button startChallengeButton;
    [SerializeField] private Button endChallengeButton;
    public static bool canCompleteGame = false;

    // Start is called before the first frame update
    void Start()
    {
        diaManager = FindObjectOfType<DialogueManager>();
        createMusicalTermsGame();
    }

    // Update is called once per frame
    void Update()
    {
        textBoxAnswers.text = correctQuestions.ToString();

    }
    // This creates our minigame choosing a correct answer from 9 possibilites.
    // A random number is chosen to select the correct answer. 
    void createMusicalTermsGame()
    {
        int rand = Random.Range(0, 9);
        answerButton1Text.text = possibleAnswers.GetValue(rand).ToString();
        int rand2 = Random.Range(0, 9);
        do // these "do" statements ensure that the random numbers cannot be the same as previously selected numbers.
        {
            rand2 = Random.Range(0, 9);
        } 
        while (rand2 == rand);

        answerButton2Text.text = possibleAnswers.GetValue(rand2).ToString();
        int rand3 = Random.Range(0, 9);                    
        do
        {
            rand3 = Random.Range(0, 9);
        } 
        while (rand3 == rand || rand3 == rand2);

        answerButton3Text.text = possibleAnswers.GetValue(rand3).ToString();
        int rand4 = Random.Range(0, 9);
        do
        {
            rand4 = Random.Range(0, 9);
        } 
        while (rand4 == rand || rand4 == rand2 || rand4 == rand3);
        answerButton4Text.text = possibleAnswers.GetValue(rand4).ToString();

        int questionID = Random.Range(1, 10);
        switch (questionID)
        {
            case 1:
                question.text = "Allegro";
                correctAnswer = possibleAnswers.GetValue(0).ToString();
                break;

            case 2:
                question.text = "Accelerando";
                correctAnswer = possibleAnswers.GetValue(1).ToString();
                break;

            case 3:
                question.text = "Crescendo";
                correctAnswer = possibleAnswers.GetValue(2).ToString();
                break;

            case 4:
                question.text = "Decrescendo";
                correctAnswer = possibleAnswers.GetValue(3).ToString();
                break;

            case 5:
                question.text = "Forte";
                correctAnswer = possibleAnswers.GetValue(4).ToString();
                break;

            case 6:
                question.text = "Fortissimo";
                correctAnswer = possibleAnswers.GetValue(5).ToString();
                break;

            case 7:
                question.text = "Piano";
                correctAnswer = possibleAnswers.GetValue(6).ToString();
                break;

            case 8:
                question.text = "Pianissimo";
                correctAnswer = possibleAnswers.GetValue(7).ToString();
                break;

            case 9:
                question.text = "Ritardando";
                correctAnswer = possibleAnswers.GetValue(8).ToString();
                break;
        } 
        RandomiseCorrectButton();
    }

    void RandomiseCorrectButton()
    {       
            int CorrectButton = Random.Range(1, 5);
            switch (CorrectButton)
            {
            
                case 1:
                    if (answerButton1Text.text != correctAnswer && answerButton2Text.text != correctAnswer && answerButton3Text.text != correctAnswer && answerButton4Text.text != correctAnswer)
                    {
                        answerButton1Text.text = correctAnswer;
                    }
                    break;


                case 2:
                if (answerButton1Text.text != correctAnswer && answerButton2Text.text != correctAnswer && answerButton3Text.text != correctAnswer && answerButton4Text.text != correctAnswer)
                {
                    answerButton2Text.text = correctAnswer;
                }
                break;

                case 3:

                if (answerButton1Text.text != correctAnswer && answerButton2Text.text != correctAnswer && answerButton3Text.text != correctAnswer && answerButton4Text.text != correctAnswer)
                {
                    answerButton3Text.text = correctAnswer;
                }
                break;

                case 4:
                if (answerButton1Text.text != correctAnswer && answerButton2Text.text != correctAnswer && answerButton3Text.text != correctAnswer && answerButton4Text.text != correctAnswer)
                {
                    answerButton4Text.text = correctAnswer;
                }
                break;
            }
        }
    
    public void SelectAnswer1()
    {
        // This function is used on each button. If the player chooses the correct answer then the score is incremented
        // and if the correct answers reaches 5/5 then the minigame will end and the player will be able to finish the game.
        if(answerButton1Text.text == correctAnswer)
        {
            correctQuestions++;
            createMusicalTermsGame();
            if (correctQuestions == 5)
            {
                EndMiniGame();
                diaManager.ShowDialogue(dialogueCorrect);
                startChallengeButton.gameObject.SetActive(false);
                endChallengeButton.gameObject.SetActive(false);
                canCompleteGame = true;

            }

        } else
        // if the player gets the wrong answer then they are taken out of the minigame and given appropriate dialogue.
        {
            EndMiniGame();
            correctQuestions = 0;
            diaManager.ShowDialogue(dialogueIncorrect);
        }

    }
    public void SelectAnswer2()
    {
        if (answerButton2Text.text == correctAnswer)
        {
            correctQuestions++;
            createMusicalTermsGame();
            
            if (correctQuestions == 5)
            {
                diaManager.ShowDialogue(dialogueCorrect);
                EndMiniGame();
                startChallengeButton.gameObject.SetActive(false);
                endChallengeButton.gameObject.SetActive(false);
                canCompleteGame = true;
            }


        }
        else
        {
            EndMiniGame();
            correctQuestions = 0;
            diaManager.ShowDialogue(dialogueIncorrect);
        }
    }


    public void SelectAnswer3()
    {
        if (answerButton3Text.text == correctAnswer)
        {
            correctQuestions++;
            createMusicalTermsGame();
            
            if (correctQuestions == 5)
            {
                diaManager.ShowDialogue(dialogueCorrect);
                EndMiniGame();
                startChallengeButton.gameObject.SetActive(false);
                endChallengeButton.gameObject.SetActive(false);
                canCompleteGame = true;
            }

        }
        else
        {
            EndMiniGame();
            correctQuestions = 0;
            diaManager.ShowDialogue(dialogueIncorrect);
        }
    }


    public void SelectAnswer4()
    {
        if (answerButton4Text.text == correctAnswer)
        {
            correctQuestions++;
            createMusicalTermsGame();
            if (correctQuestions == 5)
            {
                diaManager.ShowDialogue(dialogueCorrect);
                EndMiniGame();
                startChallengeButton.gameObject.SetActive(false);
                endChallengeButton.gameObject.SetActive(false);
                canCompleteGame = true;
            }

        }
        else
        {
            EndMiniGame();
            correctQuestions = 0;
            diaManager.ShowDialogue(dialogueIncorrect);
        }
    }
}

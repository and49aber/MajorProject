using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimeValueMiniGame : StartMinigame
{
    
    [SerializeField] private GameObject semiBreve;
    [SerializeField] private GameObject minim;
    [SerializeField] private GameObject crotchet;
    [SerializeField] private GameObject quaver;
    [SerializeField] private GameObject quaverR;
    [SerializeField] private GameObject minimR;
    [SerializeField] private GameObject crotchetR;
    private int correctAnswer;
    private int correctQuestions = 0;
    [SerializeField] private TextMeshProUGUI textBoxAnswers;
    [SerializeField] private TMP_InputField inputAnswer;
    [SerializeField] private string dialogueIncorrect;
    [SerializeField] private string dialogueCorrect;
    private DialogueManager diaManager;
    [SerializeField] private Button startChallengeButton;
    [SerializeField] private Button endChallengeButton;
    public static bool canDoubleJump = false;


    // Start is called before the first frame update
    void Start()
    {
        diaManager = FindObjectOfType<DialogueManager>();
        CreateTvalueGame();
    }

    // Update is called once per frame
    void Update()
    {
        textBoxAnswers.text = correctQuestions.ToString();  
       
    }
    //This will check the answer of the player against the correct answer. If correct, a new question is presented and their score is increased
    public void confirmAnswer()
    {
        string userAnswer = GameObject.Find("InputField").GetComponent<TMP_InputField>().text.ToString();
        if (userAnswer == correctAnswer.ToString())
        {
            correctQuestions++;
            ResetQuestion();
            CreateTvalueGame();
            GameObject.Find("InputField").GetComponent<TMP_InputField>().text = "";
            if(correctQuestions == 5)
            {
                EndTimeValueGame();
                diaManager.ShowDialogue(dialogueCorrect);
                startChallengeButton.gameObject.SetActive(false);
                endChallengeButton.gameObject.SetActive(false);
                canDoubleJump = true;
            }
            
        } else 
        {
            GameObject.Find("InputField").GetComponent<TMP_InputField>().text = "";
            EndTimeValueGame();
            correctQuestions = 0;
            ResetQuestion();
            CreateTvalueGame();
            diaManager.ShowDialogue(dialogueIncorrect);
        }
       

    }

    // Chooses random numbers which correspond to a note shown on either the left or right
    // hand side. The left note is dependant on the right note to ensure no note 
    // on the left hand side can be smaller than the note on the right. 
    private void CreateTvalueGame()
    {
        int rightNote = Random.Range(2, 5);
        switch (rightNote)
        {
            case 2:
                minimR.SetActive(true);
                semiBreve.SetActive(true);
                correctAnswer = 2;
                break;
            case 3:
                crotchetR.SetActive(true);
                int rand = Random.Range(1, 3);
                switch (rand)
                {
                    case 1:
                        minim.SetActive(true);
                        correctAnswer = 2;
                        break;
                    case 2:
                        semiBreve.SetActive(true);
                        correctAnswer = 4;
                        break;
                }
                break;
            case 4:
                quaverR.SetActive(true);
                int rand2 = Random.Range(1, 4);
                switch (rand2)
                {
                    case 1:
                        minim.SetActive(true);
                        correctAnswer = 4;
                        break;
                    case 2:
                        semiBreve.SetActive(true);
                        correctAnswer = 8;
                        break;
                    case 3:
                        crotchet.SetActive(true);
                        correctAnswer = 2;
                        break;
                }
                break;
        }
    }

    private void ResetQuestion()
    {
        minimR.SetActive(false);
        semiBreve.SetActive(false);
        crotchetR.SetActive(false);
        minim.SetActive(false);
        quaverR.SetActive(false);
        crotchet.SetActive(false);
    }

}

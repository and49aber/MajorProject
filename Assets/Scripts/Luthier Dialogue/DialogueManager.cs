using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject dialogueBox;
    public Text dialogueText;
    public bool dialogOnScreen;
    public static bool isTalking;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // closes dialog box when C is pressed
        if(dialogOnScreen && Input.GetKeyDown(KeyCode.C)){
            CloseDialogue();
        }
    }

    // shows dialog box and sets its text to the selected dialog
    public void ShowDialogue(string dialogue)
    {
        dialogOnScreen = true;
        dialogueBox.SetActive(true);
        dialogueText.text = dialogue;
        isTalking = true;
        
}

    // Closes the dialogue box
    public void CloseDialogue()
    {
        dialogueBox.SetActive(false);
        dialogOnScreen = false;
        isTalking = false;
    }

}

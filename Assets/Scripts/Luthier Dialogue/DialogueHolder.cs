using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DialogueHolder : MonoBehaviour
{
    [SerializeField] private string dialogueStart;
    private DialogueManager diaManager;
    


    // Start is called before the first frame update
    void Start()
    {
        diaManager = FindObjectOfType<DialogueManager>();
    }

    // When the player sprite is in the interactable zone of the Luthier the player may 
    // press E to open the dialog
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                diaManager.ShowDialogue(dialogueStart);
            }
        }
    }
}

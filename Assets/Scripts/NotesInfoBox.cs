using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NotesInfoBox : MonoBehaviour
{

    [SerializeField] private string noteName;
    [SerializeField] GameObject noteInfoCanvas;
    [SerializeField] private TextMeshProUGUI noteText;


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            noteText.text = noteName;
            noteInfoCanvas.SetActive(true);
            
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            noteInfoCanvas.SetActive(false);
        }
    }

}

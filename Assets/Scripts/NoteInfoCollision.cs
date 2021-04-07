using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteInfoCollision : MonoBehaviour
{
    [SerializeField] GameObject infoBox;
    [SerializeField] string infoBoxText;
    [SerializeField] private TextMeshProUGUI textInfo;


    // Update is called once per frame
    void Update()
    {
       
    }

    //when the player collides with the game object with this script an information box will appear.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            infoBox.SetActive(true);
            textInfo.text = infoBoxText;
        }
    }
    // when the player leaves the area the info box is closed.
    private void OnTriggerExit2D(Collider2D collision)
    {
        infoBox.SetActive(false);

    }
}

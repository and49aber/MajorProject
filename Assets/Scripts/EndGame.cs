using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    [SerializeField] private GameObject CannotEndGameCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
            if(MusicalTermsMiniGame.canCompleteGame == true)
            {
                SceneManager.LoadScene("End Game");
            } else if (MusicalTermsMiniGame.canCompleteGame == false)
            {
                CannotEndGameCanvas.SetActive(true);
            }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            CannotEndGameCanvas.SetActive(false);
        }
    }
}

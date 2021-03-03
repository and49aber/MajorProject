using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pMenu;
    private bool menuIsActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && menuIsActive == false){
            pMenu.SetActive(true);
            menuIsActive = true;
        }else if(menuIsActive && Input.GetKeyDown(KeyCode.Escape)){
            pMenu.SetActive(false);
            menuIsActive = false;
        }

    }
}

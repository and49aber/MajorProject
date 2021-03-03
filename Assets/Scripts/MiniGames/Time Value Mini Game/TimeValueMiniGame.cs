using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeValueMiniGame : MonoBehaviour
{
    
    [SerializeField] private GameObject semiBreve;
    [SerializeField] private GameObject minim;
    [SerializeField] private GameObject crotchet;
    [SerializeField] private GameObject quaver;
    [SerializeField] private GameObject quaverR;
    [SerializeField] private GameObject minimR;
    [SerializeField] private GameObject crotchetR;



    // Start is called before the first frame update
    void Start()
    {
        int rightNote = Random.Range(2, 5);
        switch (rightNote)
        {
            case 2:
                minimR.SetActive(true);
                semiBreve.SetActive(true);
                break;
            case 3:
                crotchetR.SetActive(true);
                int rand = Random.Range(1, 3);
                switch (rand)
                {
                    case 1:
                        minim.SetActive(true);
                        break;
                    case 2:
                        semiBreve.SetActive(true);
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
                        break;
                    case 2:
                        semiBreve.SetActive(true);
                        break;
                    case 3:
                        crotchet.SetActive(true);
                        break;
                }
                break;
        }

       

      

    }

    // Update is called once per frame
    void Update()
    {

      
    }
}

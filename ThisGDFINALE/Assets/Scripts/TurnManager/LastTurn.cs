using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LastTurn : MonoBehaviour
{
    private PlayerOne player1;
    private PlayerTwo player2;

    public GameObject oneLastPlay;

    public GameObject empty;


    //flags to check if the if statement inside the update method has executed the code in it, if that is true, it then makes sure the update method will never execute the code again.
    bool activateOnce;
    void Start()
    {
        player1 = FindObjectOfType<PlayerOne>();
        player2 = FindObjectOfType<PlayerTwo>();
        activateOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!activateOnce && ( player1.playerSO.PlayerTrainCars == 0 || player1.playerSO.PlayerTrainCars == 1 || player1.playerSO.PlayerTrainCars == 2 || (player2.playerSO.PlayerTrainCars == 0 || player2.playerSO.PlayerTrainCars == 1 || player2.playerSO.PlayerTrainCars == 2)))
        {
            StartCoroutine(waitBeforeShowing());
            activateOnce = true;
        }
        
    }

    public void DisableMessage()
    {
        Destroy(oneLastPlay.gameObject);
        empty.gameObject.SetActive(true);
    }

    IEnumerator waitBeforeShowing()
    {
        yield return new WaitForSeconds(0);
        oneLastPlay.gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScore : MonoBehaviour
{

    public GameObject bostonToMiami;

    private PlayerOne player1;
    // Start is called before the first frame update
    void Start()
    {
        player1 = FindObjectOfType<PlayerOne>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinalScores()
    {
        if(bostonToMiami.activeSelf)
        {
            player1.playerSO.PlayerScore -= 20;
        }

        else
        {
            player1.playerSO.PlayerScore += 20;
        }
    }
}

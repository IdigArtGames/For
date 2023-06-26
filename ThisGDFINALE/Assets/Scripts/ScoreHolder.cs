using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    public int scoreHeld = 0;

    public int cardPoints = 12;
    public int cardPoints1 = 13;
    public int cardPoints2 = 13;

    private CalgaryPhoenix calgaryPhoenix;
    private CalgarySaltLake calgarySaltLake;
    private BostonMiami bostonMiami;
    // Start is called before the first frame update
    void Start()
    {
        calgarySaltLake = FindObjectOfType<CalgarySaltLake>();
        calgaryPhoenix = FindObjectOfType<CalgaryPhoenix>();
        bostonMiami = FindObjectOfType<BostonMiami>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bostonMiami.disableThis == null)
        {
            scoreHeld += cardPoints;
        }
        if (calgaryPhoenix.disableThis == null)
        {
            scoreHeld += cardPoints1;
        }

        if (calgaryPhoenix.disableThis == null)
        {
            scoreHeld += cardPoints2;
        }

    }
}

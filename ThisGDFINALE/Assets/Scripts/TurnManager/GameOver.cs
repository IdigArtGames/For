using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private JustToTest toTest;
    public GameObject gameOver;

    private PlayerOne playerOne;
    private PlayerTwo playerTwo;

    public TMP_Text score;
    public TMP_Text score1;

    public TMP_Text Winner;
    public TMP_Text Winner2;

    [Header("Destinations")]
    public GameObject BM;
    public GameObject CP;
    public GameObject CS;
    public GameObject CS1;
    public GameObject DN;
    public GameObject DE;
    public GameObject DP;
    public GameObject DE1;
    public GameObject DH;
    public GameObject HL;
    public GameObject KH;
    public GameObject LC;
    public GameObject LM;
    public GameObject LN;
    public GameObject MA;
    public GameObject MN;
        
    public GameObject NA;
    public GameObject PN;
        
    public GameObject SA;
    public GameObject SO;
    public GameObject SN;
    public GameObject TM;
    public GameObject VM;
    public GameObject VS;
    public GameObject WH;

    [Header("Num")]
    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Four;
    public GameObject Five;
    public GameObject Six;
    public GameObject Seven;
    public GameObject Eight;
    public GameObject Nine;
    public GameObject Ten;
    public GameObject Eleven;
    public GameObject Twelve;
    public GameObject Thirteen;
    public GameObject Fourteen;
    public GameObject Fifteen;
    public GameObject SixTeen;

    public GameObject SevenTeen;
    public GameObject Eighteen;

    public GameObject Nineteen;
    public GameObject Twenty;
    public GameObject TwentyOne;
    public GameObject TwentyTwo;
    public GameObject TwentyThree;
    public GameObject TwentyFour;
    public GameObject TwentyFive;

    void Start()
    {
        playerTwo = FindObjectOfType<PlayerTwo>();
        playerOne = FindObjectOfType<PlayerOne>();
        toTest = FindObjectOfType<JustToTest>();
    }

    // Update is called once per frame
    void Update()
    {
        if(toTest.callCount == 2)
        {
            gameOver.gameObject.SetActive(true);
            score.text ="Player1:"+ playerOne.playerSO.PlayerScore.ToString();

            score1.text = "Player2:" + playerTwo.playerSO.PlayerScore.ToString();
            if(playerOne.playerSO.PlayerScore > playerTwo.playerSO.PlayerScore)
            {
                Winner.gameObject.SetActive(true);
            }
            else
            {
                Winner2.gameObject.SetActive(true);
            }

            if (BM.activeSelf && One == null)
            {
                playerOne.playerSO.PlayerScore -= 12;
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
            }
            if (CP.activeSelf && Two == null)
            {
                playerOne.playerSO.PlayerScore -= 13;
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
            }

            if (CS.activeSelf && Three == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 7;
            }
            if (CS1.activeSelf && Four == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 9;
            }

            if (DN.activeSelf && Five == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 11;
            }

            if (DE.activeSelf && Six == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 4;
            }

            if (DP.activeSelf && Seven == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 11;
            }
            if (DE1.activeSelf && Eight == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 10;
            }
            if (DH.activeSelf && Nine == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 8;
            }
            if (HL.activeSelf && Ten == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 8;
            }
            if (KH.activeSelf && Eleven == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 5;
            }
            if (LC.activeSelf && Twelve == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 16;
            }
            if (LM.activeSelf && Thirteen == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 20;
            }
            if (LN.activeSelf && Fourteen == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 21;
            }
            if (MA.activeSelf && Fifteen == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 9;
            }
            if (MN.activeSelf && SixTeen == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 13;
            }
            if (NA.activeSelf && SevenTeen == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 6;
            }
            if (PN.activeSelf && Eleven == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 17;
            }
            if (SA.activeSelf && Nineteen == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 17;
            }
            if (SO.activeSelf && Twenty == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -=9;
            }
            if (SN.activeSelf && TwentyOne == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 22;
            }
            if (TM.activeSelf && TwentyTwo == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 10;
            }

            if (VM.activeSelf && TwentyThree == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 20;
            }
            if (VS.activeSelf && TwentyFour == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 13;
            }
            if (WH.activeSelf && TwentyFive == null)
            {
                score.text = "Player1:" + playerOne.playerSO.PlayerScore.ToString();
                playerOne.playerSO.PlayerScore -= 12;
            }

        }

    }
}

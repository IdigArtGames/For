using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class JustToTest : MonoBehaviour
{
    //GameObjects
    public GameObject player1;
    public GameObject player2;
    //Other classes refs
    public ParentScript parentScript;
    public playerManage playerManage;

    //blackScreen GameObject
    public GameObject blackScreen;

    public Animator textAnim;

    private float AfterThis = 5;

    public int callCount;

    [Header("Scripts")]
    public Grey2 grey;
    public SecondPlayerGrey2 secondPlayerGrey;
    public Grey6 grey6;
    public SecondPlayerGrey6 greyPlayer;

    public Grey7 grey7;
    public SecondPlayerGrey7 greyPlayer7;
    public Grey8 grey8;
    public SecondPlayerGrey8 greyPlayer8;
    public Grey9 grey9;
    public SecondPlayerGrey9 greyPlayer9;

    public GameObject empty;

    public GameObject playerOne;
    public GameObject playerTwo;



    public GameObject OneLastPlay;
    public void Change()
    {
        if (playerOne.activeSelf)
        {
            secondPlayerGrey.enabled = true;
            grey.enabled = false;
            greyPlayer.enabled = true;  
            grey6.enabled = false;
            greyPlayer7.enabled = true;
            grey7.enabled = false;
            greyPlayer8.enabled = true;
            grey8.enabled = false;
            greyPlayer9.enabled = true;
            grey9.enabled = false;
        }
        else
        {
            secondPlayerGrey.enabled = false;
            grey.enabled = true;

            greyPlayer.enabled = false;
            grey6.enabled = true;
            grey7.enabled = true;
            greyPlayer7.enabled = false;
            grey8.enabled = true;
            greyPlayer8.enabled = false;
            grey9.enabled = true;
            greyPlayer9.enabled = false;
        }

        if (playerTwo.activeSelf)
        {
            grey7.enabled = true;
            grey8.enabled = true;
            grey9.enabled = true;
            grey.enabled = true;
            secondPlayerGrey.enabled = false;
            greyPlayer.enabled = false;
            grey6.enabled = true;
            greyPlayer7.enabled = false;
            greyPlayer8.enabled = false;
            greyPlayer9.enabled = false;

        }
        else
        {
            grey.enabled = false;
            secondPlayerGrey.enabled = true;
            greyPlayer.enabled = true;
            grey6.enabled = false;
            grey7.enabled = false;
            grey8.enabled = false;
            grey9.enabled = false;
            greyPlayer7.enabled = true;
            greyPlayer8.enabled = true;
            greyPlayer9.enabled = true;
        }



        if (OneLastPlay == null && empty!= null)
        {
            callCount++;
            print(callCount);
        }
        //whenever this method is called, the blackscreen will get activated
        blackScreen.SetActive(true);
        textAnim.SetTrigger("StartAnim");
        StartCoroutine(DisableThis());
        //calls
        playerManage.DoThis();
        parentScript.Box();
        parentScript.Freight();
        if (player1 != null && player2 == null )
        {
            player1.SetActive(false);
            player2.SetActive(true);
        }
        else if (player2 != null && player1 != null )
        {
            //a bool that toggles these gameObjects On/Off based on their current active state
            bool isPlayer1Active = player1.activeSelf;
            player1.SetActive(!isPlayer1Active);
            player2.SetActive(isPlayer1Active);
        }
    }

    private IEnumerator DisableThis()
    {
        yield return new WaitForSeconds(AfterThis);
        // we will disable the blackscreen gameObject after "afterThis" seconds.
        blackScreen.SetActive(false);
    }
}

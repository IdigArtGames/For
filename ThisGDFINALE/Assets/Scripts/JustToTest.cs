using UnityEngine;

public class JustToTest : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public ParentScript parentScript;
    public playerManage playerManage;


    public void Change()
    {
        //calls
        playerManage.DoThis();
        parentScript.Box();
        parentScript.Freight();
        if (player1 != null && player2 == null && player3 != null && player4 == null)
        {
            player1.SetActive(false);
            player2.SetActive(true);
            player3.SetActive(false);
            player4.SetActive(true);
        }
        else if (player2 != null && player1 != null && player4 != null && player3 != null)
        {
            bool isPlayer1Active = player1.activeSelf;
            player1.SetActive(!isPlayer1Active);
            player2.SetActive(isPlayer1Active);
            player3.SetActive(!isPlayer1Active);
            player4.SetActive(isPlayer1Active);
        }
    }
}

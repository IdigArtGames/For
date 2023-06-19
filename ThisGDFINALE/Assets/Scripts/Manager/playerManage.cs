using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManage : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public GameObject playerDest1;
    public GameObject playerDest2;

    public void DoThis()
    {
        if(player1 != null && player2 == null && playerDest1 != null && playerDest2 ==null)
        {
            player1.SetActive(false);
            player2.SetActive(true);

            playerDest1.SetActive(false);
            playerDest2.SetActive(true);
        }

        else if(player2 != null && player1!=null && playerDest2 != null && playerDest1 != null)
        {
           bool isActive =  player1.activeSelf;
           player1.SetActive(!isActive);
           player2.SetActive(isActive);
           bool isActive2 = playerDest1.activeSelf;
           playerDest1.SetActive(!isActive2);
           playerDest2.SetActive(isActive2);
        }
    }
}

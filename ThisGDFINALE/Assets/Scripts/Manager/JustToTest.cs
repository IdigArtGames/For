using System.Collections;
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

    private float AfterThis = 0;
    public void Change()
    {
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

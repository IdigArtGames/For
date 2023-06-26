using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SeattleNewYork : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject TwentyOne;
    [Header("~~~~~~~~~~~~~~Seattle~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject SV;
    [SerializeField] private GameObject SC;
    [SerializeField] private GameObject SH;
    [SerializeField] private GameObject SP;

    [Header("~~~~~~~~~~~~~~New York~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject NP;
    [SerializeField] private GameObject NP1;
    [SerializeField] private GameObject NW;
    [SerializeField] private GameObject NW1;
    [SerializeField] private GameObject NB;
    [SerializeField] private GameObject NB1;
    [SerializeField] private GameObject NM;


    public GameObject disableThis;

    public int GiveOrTake = 22;

    void Start()
    {
        player1 = FindObjectOfType<PlayerOne>();
    }

    void Update()
    {
        RouteComplete();
    }
 
    private void RouteComplete()
    {
        if ((SV.activeSelf || SC.activeSelf || SH.activeSelf || SP.activeSelf) && (NP.activeSelf || NP1.activeSelf || NW.activeSelf||NW1||NB.activeSelf|| NB1.activeSelf|| NM.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                TwentyOne.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

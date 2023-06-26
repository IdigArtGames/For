using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LosAngelesNewYork : MonoBehaviour
{


    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject Fourteen;
    [Header("~~~~~~~~~~~~~~Los Angeles~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject LE;
    [SerializeField] private GameObject LP;
    [SerializeField] private GameObject LL;
    [SerializeField] private GameObject LS;
    [SerializeField] private GameObject LS1;

    [Header("~~~~~~~~~~~~~~NewYork~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject NP;
    [SerializeField] private GameObject NP1;
    [SerializeField] private GameObject NW;
    [SerializeField] private GameObject NW1;
    [SerializeField] private GameObject NB;
    [SerializeField] private GameObject NB1;
    [SerializeField] private GameObject NM;


    public GameObject disableThis;

    public int GiveOrTake = 21;

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
        if ((LE.activeSelf || LP.activeSelf || LL.activeSelf || LS.activeSelf || LS1.activeSelf) && (NP.activeSelf || NP1.activeSelf || NW.activeSelf || NW1 || NB.activeSelf || NB1.activeSelf || NM.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Fourteen.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

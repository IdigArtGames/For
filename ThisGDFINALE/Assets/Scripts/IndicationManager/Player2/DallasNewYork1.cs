using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DallasNewYork1 : MonoBehaviour
{


    public GameObject player2Stuff;
    private PlayerTwo player2;

    public GameObject Five;

    [Header("~~~~~~~~~~~~~~Dallas~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject DH;
    [SerializeField] private GameObject DO;
    [SerializeField] private GameObject DE;
    [SerializeField] private GameObject DL;

    [Header("~~~~~~~~~~~~~~NewYork~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject NP;
    [SerializeField] private GameObject NP1;
    [SerializeField] private GameObject NW;
    [SerializeField] private GameObject NW1;
    [SerializeField] private GameObject NB;
    [SerializeField] private GameObject NB1;
    [SerializeField] private GameObject NM;


    public GameObject disableThis;

    public int GiveOrTake = 11;

    void Start()
    {
        player2 = FindObjectOfType<PlayerTwo>();
    }

    void Update()
    {
        RouteComplete();
    }

    private void RouteComplete()
    {
        if ((DH.activeSelf || DO.activeSelf || DE.activeSelf || DL) && (NP.activeSelf || NP1.activeSelf || NW.activeSelf || NW1 || NB.activeSelf || NB1.activeSelf || NM.activeSelf) && player2Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player2.playerSO.PlayerScore += GiveOrTake;
                Five.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

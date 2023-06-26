using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;

public class DenverPittsburg : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;

    public GameObject Seven;
    [Header("~~~~~~~~~~~~~~Denver~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject DK;
    [SerializeField] private GameObject DK1;
    [SerializeField] private GameObject DO;
    [SerializeField] private GameObject DS;
    [SerializeField] private GameObject DP;
    [SerializeField] private GameObject DS1;
    [SerializeField] private GameObject DS2;
    [SerializeField] private GameObject DH;

    [Header("~~~~~~~~~~~~~~Pittsburg~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject PW;
    [SerializeField] private GameObject PN;
    [SerializeField] private GameObject PT;
    [SerializeField] private GameObject PC;
    [SerializeField] private GameObject PC1;
    [SerializeField] private GameObject PN1;
    [SerializeField] private GameObject PS;
    [SerializeField] private GameObject PN2;
    [SerializeField] private GameObject PR;


    public GameObject disableThis;

    public int GiveOrTake = 11;

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
        if ((DK.activeSelf || DK1.activeSelf || DO.activeSelf || DS.activeSelf || DP.activeSelf || DS1.activeSelf || DS2.activeSelf || DH.activeSelf) && (PN2.activeSelf|| PR.activeSelf||PC.activeSelf||PC1.activeSelf|| PS.activeSelf|| PN1.activeSelf||PW.activeSelf || PN.activeSelf || PT.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Seven.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

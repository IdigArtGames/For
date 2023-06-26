using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SaultStMarieOklahoma : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject Twenty;
    [Header("~~~~~~~~~~~~~~Sault St. Marie~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject ST;
    [SerializeField] private GameObject SW;
    [SerializeField] private GameObject SD;
    [SerializeField] private GameObject SM;

    [Header("~~~~~~~~~~~~~~Oklahoma~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject OK;
    [SerializeField] private GameObject OL;
    [SerializeField] private GameObject OD;
    [SerializeField] private GameObject OS;
    [SerializeField] private GameObject OD1;
    [SerializeField] private GameObject OE;


    public GameObject disableThis;

    public int GiveOrTake = 20;

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
        if ((ST.activeSelf || SW.activeSelf || SD.activeSelf || SM.activeSelf) && (OK.activeSelf || OL.activeSelf || OD.activeSelf || OS.activeSelf || OD1.activeSelf || OE.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Twenty.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

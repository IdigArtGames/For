using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PortlandNashville: MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;

    public GameObject Eighteen;

    [Header("~~~~~~~~~~~~~~Portland~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject PS;
    [SerializeField] private GameObject PS1;
    [SerializeField] private GameObject PS2;
    [SerializeField] private GameObject PS3;

    [Header("~~~~~~~~~~~~~~Nashville~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject NA;
    [SerializeField] private GameObject NR;
    [SerializeField] private GameObject NP;
    [SerializeField] private GameObject NS;
    [SerializeField] private GameObject NL;



    public GameObject disableThis;

    public int GiveOrTake = 17;

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
        if ((PS.activeSelf || PS1.activeSelf || PS2.activeSelf || PS3.activeSelf) && (NA.activeSelf || NR.activeSelf || NP.activeSelf || NS.activeSelf || NL.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Eighteen.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

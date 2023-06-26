using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DuluthHouston : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;

    public GameObject Nine;

    [Header("~~~~~~~~~~~~~~Duluth~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject DO;
    [SerializeField] private GameObject DC;
    [SerializeField] private GameObject DT;
    [SerializeField] private GameObject DS;
    [SerializeField] private GameObject DW;
    [SerializeField] private GameObject DH;


    [Header("~~~~~~~~~~~~~~Houston~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject HN;
    [SerializeField] private GameObject HD;
    [SerializeField] private GameObject HE;


    public GameObject disableThis;

    public int GiveOrTake = 8;

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
        if ((DO.activeSelf || DC.activeSelf || DT.activeSelf || DS.activeSelf || DW.activeSelf || DH.activeSelf) && (HN.activeSelf || HD.activeSelf || HE.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Nine.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

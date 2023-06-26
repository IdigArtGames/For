using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MontrealNewOrleans : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject Sixteen;

    [Header("~~~~~~~~~~~~~~Montreal~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject MB;
    [SerializeField] private GameObject MT;
    [SerializeField] private GameObject MN;
    [SerializeField] private GameObject MS;

    [Header("~~~~~~~~~~~~~~New Orleans~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject NM;
    [SerializeField] private GameObject NH;
    [SerializeField] private GameObject NL;
    [SerializeField] private GameObject NA;
    [SerializeField] private GameObject NA1;


    public GameObject disableThis;

    public int GiveOrTake = 13;

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
        if ((NM.activeSelf || NH.activeSelf || NL.activeSelf || NA.activeSelf|| NA1.activeSelf) && (MB.activeSelf || MT.activeSelf || MN.activeSelf || MS.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Sixteen.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

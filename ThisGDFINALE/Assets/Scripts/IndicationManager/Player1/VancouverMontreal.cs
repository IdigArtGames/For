using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VancouverMontreal : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject TwentyThree;
    [Header("~~~~~~~~~~~~~~Vancouver~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject VS;
    [SerializeField] private GameObject VC;

    [Header("~~~~~~~~~~~~~~Montreal~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject MB;
    [SerializeField] private GameObject MT;
    [SerializeField] private GameObject MN;
    [SerializeField] private GameObject MS;


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
        if ((VS.activeSelf || VC.activeSelf) && (MB.activeSelf || MT.activeSelf || MN.activeSelf || MS.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                TwentyThree.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WinnipegHouston : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject Twentyfive;
    [Header("~~~~~~~~~~~~~~Miami~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject HD;
    [SerializeField] private GameObject HN;
    [SerializeField] private GameObject HE;

    [Header("~~~~~~~~~~~~~~Boston~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject WS;
    [SerializeField] private GameObject WH;
    [SerializeField] private GameObject WD;
    [SerializeField] private GameObject WC;

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
        if ((HD.activeSelf || HN.activeSelf || HE.activeSelf) && (WS.activeSelf || WH.activeSelf || WD.activeSelf || WC.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Twentyfive.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

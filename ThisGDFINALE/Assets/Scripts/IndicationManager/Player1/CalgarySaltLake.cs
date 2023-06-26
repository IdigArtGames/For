using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CalgarySaltLake: MonoBehaviour
{


    public GameObject player1Stuff;
    private PlayerOne player1;

    public GameObject Three;
    [Header("~~~~~~~~~~~~~~Calgary~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject CH;
    [SerializeField] private GameObject CW;
    [SerializeField] private GameObject CV;
    [SerializeField] private GameObject CS;

    [Header("~~~~~~~~~~~~~~Boston~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject SH;
    [SerializeField] private GameObject SP;
    [SerializeField] private GameObject SL;
    [SerializeField] private GameObject SD;
    [SerializeField] private GameObject SD1;
    [SerializeField] private GameObject SS;
    [SerializeField] private GameObject SS1;



    public GameObject disableThis;

    public int GiveOrTake = 7;

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
        if ((CH.activeSelf || CW.activeSelf || CV.activeSelf || CS.activeSelf) && (SS1.activeSelf||SS.activeSelf||SD1.activeSelf||SD.activeSelf||SH.activeSelf || SP.activeSelf || SL.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Three.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CalgaryPhoenix : MonoBehaviour
{
    public GameObject Two;
    public GameObject player1Stuff;

    [Header("~~~~~~~~~~~~~~Calgary~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject CH;
    [SerializeField] private GameObject CW;
    [SerializeField] private GameObject CV;
    [SerializeField] private GameObject CS;

    [Header("~~~~~~~~~~~~~~Phoenix~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject PE;
    [SerializeField] private GameObject PD;
    [SerializeField] private GameObject PS;
    [SerializeField] private GameObject PL;

    private PlayerOne player1;

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
        if ((CH.activeSelf || CW.activeSelf || CV.activeSelf || CS.activeSelf) && (PE.activeSelf || PD.activeSelf || PS.activeSelf|| PL.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Two.SetActive(true);   
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TorontoMiami : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject Twentytwo;
    [Header("~~~~~~~~~~~~~~Toronto~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject TP;
    [SerializeField] private GameObject TC;
    [SerializeField] private GameObject TD;
    [SerializeField] private GameObject TS;
    [SerializeField] private GameObject TM;

    [Header("~~~~~~~~~~~~~~Miami~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject MC;
    [SerializeField] private GameObject MA;
    [SerializeField] private GameObject MN;

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
        if ((TP.activeSelf || TM.activeSelf || TC.activeSelf || TD || TS.activeSelf) && (MC.activeSelf || MA.activeSelf || MN.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Twentytwo.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

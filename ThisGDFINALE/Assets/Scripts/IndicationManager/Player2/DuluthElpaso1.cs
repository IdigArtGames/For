using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DuluthElpaso1 : MonoBehaviour
{

    public GameObject player2Stuff;
    private PlayerTwo player2;
    public GameObject Eight;

    [Header("~~~~~~~~~~~~~~Duluth~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject DO;
    [SerializeField] private GameObject DC;
    [SerializeField] private GameObject DT;
    [SerializeField] private GameObject DS;
    [SerializeField] private GameObject DW;
    [SerializeField] private GameObject DH;

    [Header("~~~~~~~~~~~~~~El Paso~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject EH;
    [SerializeField] private GameObject ED;
    [SerializeField] private GameObject EL;
    [SerializeField] private GameObject EP;
    [SerializeField] private GameObject ES;
    [SerializeField] private GameObject EO;


    public GameObject disableThis;

    public int GiveOrTake = 10;

    void Start()
    {
        player2 = FindObjectOfType<PlayerTwo>();
    }

    void Update()
    {
        RouteComplete();
    }

    private void RouteComplete()
    {
        if ((DO.activeSelf || DC.activeSelf || DT.activeSelf || DS.activeSelf|| DW.activeSelf|| DH.activeSelf) && (EO.activeSelf || ES.activeSelf || EP.activeSelf || EH.activeSelf || ED.activeSelf || EL.activeSelf) && player2Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player2.playerSO.PlayerScore += GiveOrTake;
                Eight.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

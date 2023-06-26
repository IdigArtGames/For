using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SanFranciscoAtlanta : MonoBehaviour
{


    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject Nineteen;
    [Header("~~~~~~~~~~~~~~San Francisco~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject SS;
    [SerializeField] private GameObject SS1;
    [SerializeField] private GameObject SP;
    [SerializeField] private GameObject SP1;
    [SerializeField] private GameObject SL;
    [SerializeField] private GameObject SL1;

    [Header("~~~~~~~~~~~~~~Atlanta~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject AC;
    [SerializeField] private GameObject AR;
    [SerializeField] private GameObject AN;
    [SerializeField] private GameObject AN1;
    [SerializeField] private GameObject AN2;
  

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
        if ((SS.activeSelf || SS1.activeSelf || SP.activeSelf || SP1.activeSelf || SL.activeSelf || SL1) && (AC.activeSelf || AR.activeSelf || AN.activeSelf ||AN1.activeSelf ||AN2.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Nineteen.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

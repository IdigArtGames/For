using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BostonMiami : MonoBehaviour
{


    public GameObject player1Stuff;

    public GameObject One;
    private PlayerOne player1;

    [Header("~~~~~~~~~~~~~~Miami~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject M_C;
    [SerializeField] private GameObject M_A;
    [SerializeField] private GameObject M_N;

    [Header("~~~~~~~~~~~~~~Boston~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject N_B;
    [SerializeField] private GameObject B_N;
    public GameObject B_M;

    public GameObject disableThis;

    public int GiveOrTake = 12;

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
        if((M_C.activeSelf ||  M_A.activeSelf ||M_N.activeSelf) &&(N_B.activeSelf || B_N.activeSelf || B_M.activeSelf) && player1Stuff.activeSelf)
        {
            if(disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                One.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }
            
        }
    }
}

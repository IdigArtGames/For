using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BostonMiami1: MonoBehaviour
{

    public GameObject player2Stuff;
    private PlayerTwo player2;
    public GameObject One;
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
        player2 = FindObjectOfType<PlayerTwo>();
    }

    void Update()
    {
        RouteComplete();
    }

    private void RouteComplete()
    {
        if ((M_C.activeSelf || M_A.activeSelf || M_N.activeSelf) && (N_B.activeSelf || B_N.activeSelf || B_M.activeSelf) && player2Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                One.SetActive(true);
                disableThis.gameObject.SetActive(false);
                player2.playerSO.PlayerScore += GiveOrTake;
            }

        }
    }
}

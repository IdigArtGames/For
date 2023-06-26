using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LosAngelesMiami1 : MonoBehaviour
{

    public GameObject player2Stuff;
    private PlayerTwo player2;

    public GameObject Thirteen;
    [Header("~~~~~~~~~~~~~~Miami~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject M_C;
    [SerializeField] private GameObject M_A;
    [SerializeField] private GameObject M_N;

    [Header("~~~~~~~~~~~~~~Los Angeles~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject LE;
    [SerializeField] private GameObject LP;
    [SerializeField] private GameObject LL;
    [SerializeField] private GameObject LS;
    [SerializeField] private GameObject LS1;


    public GameObject disableThis;

    public int GiveOrTake = 20;

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
        if ((M_C.activeSelf || M_A.activeSelf || M_N.activeSelf) && (LE.activeSelf || LP.activeSelf || LL.activeSelf || LS.activeSelf || LS1.activeSelf) && player2Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player2.playerSO.PlayerScore += GiveOrTake;
                Thirteen.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

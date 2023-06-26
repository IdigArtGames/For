using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LosAngelesChicago : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;

    public GameObject Twelve;

    [Header("~~~~~~~~~~~~~~Chicago~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject CS;
    [SerializeField] private GameObject CS1;
    [SerializeField] private GameObject CP;
    [SerializeField] private GameObject CP1;
    [SerializeField] private GameObject CT;
    [SerializeField] private GameObject CO;
    [SerializeField] private GameObject CD;

    [Header("~~~~~~~~~~~~~~Los Angeles~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject LE;
    [SerializeField] private GameObject LP;
    [SerializeField] private GameObject LL;
    [SerializeField] private GameObject LS;
    [SerializeField] private GameObject LS1;


    public GameObject disableThis;

    public int GiveOrTake = 16;

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
        if ((CS.activeSelf || CS1.activeSelf || CP.activeSelf || CP1.activeSelf || CT.activeSelf || CO.activeSelf || CD.activeSelf) && (LE.activeSelf || LP.activeSelf || LL.activeSelf || LS.activeSelf || LS1.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Twelve.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

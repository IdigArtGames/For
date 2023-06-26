using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HelenaLosAngeles : MonoBehaviour
{

    public GameObject Ten;

    public GameObject player1Stuff;
    private PlayerOne player1;
    [Header("~~~~~~~~~~~~~~Los Angeles~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject LE;
    [SerializeField] private GameObject LP;
    [SerializeField] private GameObject LL;
    [SerializeField] private GameObject LS;
    [SerializeField] private GameObject LS1;

    [Header("~~~~~~~~~~~~~~Helena~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject HS;
    [SerializeField] private GameObject HD;
    [SerializeField] private GameObject HO;
    [SerializeField] private GameObject HD1;
    [SerializeField] private GameObject HC;
    [SerializeField] private GameObject HW;
    [SerializeField] private GameObject HS1;


    public GameObject disableThis;

    public int GiveOrTake = 8;

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
        if ((LE.activeSelf || LP.activeSelf || LL.activeSelf || LS.activeSelf || LS1.activeSelf) && (HS1.activeSelf||HD1.activeSelf || HC.activeSelf || HW.activeSelf|| HS.activeSelf || HD.activeSelf || HO.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                Ten.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

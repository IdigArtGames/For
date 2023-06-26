using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChicagoSantaFe1 : MonoBehaviour
{

    public GameObject player2Stuff;
    private PlayerTwo player2;

    public GameObject Four;

    [Header("~~~~~~~~~~~~~~Chicago~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject CS;
    [SerializeField] private GameObject CS1;
    [SerializeField] private GameObject CP;
    [SerializeField] private GameObject CP1;
    [SerializeField] private GameObject CT;
    [SerializeField] private GameObject CO;
    [SerializeField] private GameObject CD;


    [Header("~~~~~~~~~~~~~~Santa Fe~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject SE;
    [SerializeField] private GameObject SO;
    [SerializeField] private GameObject SP;
    [SerializeField] private GameObject SD;

    public GameObject disableThis;

    public int GiveOrTake = 9;

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
        if ((CS.activeSelf || CS1.activeSelf || CP.activeSelf || CP1.activeSelf || CT.activeSelf || CO.activeSelf || CD.activeSelf) && (SE.activeSelf || SO.activeSelf || SP.activeSelf || SD.activeSelf) && player2Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player2.playerSO.PlayerScore += GiveOrTake;
                Four.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class VancouverSantaFe : MonoBehaviour
{


    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject Twentyfour;
    [Header("~~~~~~~~~~~~~~Vancouver~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject VC;
    [SerializeField] private GameObject VS;

    [Header("~~~~~~~~~~~~~~Santa Fe~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject SE;
    [SerializeField] private GameObject SO;
    [SerializeField] private GameObject SP;
    [SerializeField] private GameObject SD;

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
        if ((VC.activeSelf || VS.activeSelf) && (SE.activeSelf || SO.activeSelf || SP.activeSelf || SD.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Twentyfour.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

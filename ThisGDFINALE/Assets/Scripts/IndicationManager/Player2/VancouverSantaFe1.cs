using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class VancouverSantaFe1 : MonoBehaviour
{


    public GameObject player2Stuff;
    private PlayerTwo player2;
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
        player2 = FindObjectOfType<PlayerTwo>();
    }

    void Update()
    {
        RouteComplete();
    }


    private void RouteComplete()
    {
        if ((VC.activeSelf || VS.activeSelf) && (SE.activeSelf || SO.activeSelf || SP.activeSelf || SD.activeSelf) && player2Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player2.playerSO.PlayerScore += GiveOrTake;
                Twentyfour.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

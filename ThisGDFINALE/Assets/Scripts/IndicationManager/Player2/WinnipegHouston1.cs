using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WinnipegHouston1 : MonoBehaviour
{

    public GameObject player2Stuff;
    private PlayerTwo player2;
    public GameObject Twentyfive;
    [Header("~~~~~~~~~~~~~~Houston~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject HD;
    [SerializeField] private GameObject HN;
    [SerializeField] private GameObject HE;

    [Header("~~~~~~~~~~~~~~Winnipeg~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject WS;
    [SerializeField] private GameObject WH;
    [SerializeField] private GameObject WD;
    [SerializeField] private GameObject WC;

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
        if ((HD.activeSelf || HN.activeSelf || HE.activeSelf) && (WS.activeSelf || WH.activeSelf || WD.activeSelf || WC.activeSelf) && player2Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player2.playerSO.PlayerScore += GiveOrTake;
                Twentyfive.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

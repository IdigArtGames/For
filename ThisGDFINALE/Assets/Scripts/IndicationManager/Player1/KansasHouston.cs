using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KansasHouston: MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;

    public GameObject Eleven;

    [Header("~~~~~~~~~~~~~~Kansas City~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject KS;
    [SerializeField] private GameObject KS1;
    [SerializeField] private GameObject KO;
    [SerializeField] private GameObject KD;
    [SerializeField] private GameObject KD1;
    [SerializeField] private GameObject KO1;

    [Header("~~~~~~~~~~~~~~Houston~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject HN;
    [SerializeField] private GameObject HD;
    [SerializeField] private GameObject HE;


    public GameObject disableThis;

    public int GiveOrTake = 5;

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
        if ((KO1.activeSelf||KS.activeSelf || KS1.activeSelf || KO.activeSelf || KD.activeSelf || KD1.activeSelf) && (HN.activeSelf || HD.activeSelf || HE.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Eleven.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

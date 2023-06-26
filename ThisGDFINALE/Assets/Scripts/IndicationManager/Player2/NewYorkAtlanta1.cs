using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewYorkAtlanta1 : MonoBehaviour


{


    public GameObject SevenTeen;

    public GameObject player2Stuff;
    private PlayerTwo player2;
    [Header("New York")]
    [SerializeField] private GameObject NP;
    [SerializeField] private GameObject NP1;
    [SerializeField] private GameObject NW;
    [SerializeField] private GameObject NW1;
    [SerializeField] private GameObject NB;
    [SerializeField] private GameObject NB1;
    [SerializeField] private GameObject NM;
    [Header("Atlanta")]
    [SerializeField] private GameObject AC;
    [SerializeField] private GameObject AR;
    [SerializeField] private GameObject AN;
    [SerializeField] private GameObject AN1;
    [SerializeField] private GameObject AN2;

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
        if ((NP.activeSelf || NP1.activeSelf || NW.activeSelf || NW1 || NB.activeSelf || NB1.activeSelf || NM.activeSelf) && (AC.activeSelf || AR.activeSelf || AN.activeSelf || AN1.activeSelf || AN2.activeSelf) && player2Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player2.playerSO.PlayerScore += GiveOrTake;
                SevenTeen.SetActive (true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

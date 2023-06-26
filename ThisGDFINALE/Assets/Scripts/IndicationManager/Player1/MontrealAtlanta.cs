using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MontrealAtlanta : MonoBehaviour
{

    public GameObject player1Stuff;
    private PlayerOne player1;
    public GameObject Fifteen;
    [Header("~~~~~~~~~~~~~~Atlanta~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject AC;
    [SerializeField] private GameObject AR;
    [SerializeField] private GameObject AN;
    [SerializeField] private GameObject AN1;
    [SerializeField] private GameObject AN2;
    [SerializeField] private GameObject AM;

    [Header("~~~~~~~~~~~~~~Montreal~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject MB;
    [SerializeField] private GameObject MT;
    [SerializeField] private GameObject MN;
    [SerializeField] private GameObject MS;


    public GameObject disableThis;

    public int GiveOrTake = 9;

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
        if ((AM.activeSelf||AC.activeSelf || AR.activeSelf || AN.activeSelf || AN1.activeSelf || AN2.activeSelf) && (MB.activeSelf || MT.activeSelf || MN.activeSelf || MS.activeSelf) && player1Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player1.playerSO.PlayerScore += GiveOrTake;
                Fifteen.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

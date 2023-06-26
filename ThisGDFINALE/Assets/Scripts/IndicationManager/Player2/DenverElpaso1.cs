using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DenverElpaso1 : MonoBehaviour
{

    public GameObject player2Stuff;
    private PlayerTwo player2;

    public GameObject Six;
    [Header("~~~~~~~~~~~~~~Denver~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject DK;
    [SerializeField] private GameObject DK1;
    [SerializeField] private GameObject DO;
    [SerializeField] private GameObject DS;
    [SerializeField] private GameObject DP;
    [SerializeField] private GameObject DS1;
    [SerializeField] private GameObject DS2;
    [SerializeField] private GameObject DH;
    [SerializeField] private GameObject DO1;

    [Header("~~~~~~~~~~~~~~El Paso~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject EH;
    [SerializeField] private GameObject ED;
    [SerializeField] private GameObject EL;
    [SerializeField] private GameObject EP;
    [SerializeField] private GameObject ES;
    [SerializeField] private GameObject EO;


    public GameObject disableThis;

    public int GiveOrTake = 4;

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
        if ((DO1.activeSelf||DK.activeSelf || DK1.activeSelf || DO.activeSelf || DS.activeSelf || DP.activeSelf || DS1.activeSelf || DS2.activeSelf || DH.activeSelf) && (EO.activeSelf||ES.activeSelf||EP.activeSelf||EH.activeSelf || ED.activeSelf || EL.activeSelf) && player2Stuff.activeSelf)
        {
            if (disableThis.activeSelf && Input.GetMouseButtonUp(0))
            {
                player2.playerSO.PlayerScore += GiveOrTake;
                Six.SetActive(true);
                disableThis.gameObject.SetActive(false);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BostonMiami : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private GameObject ind1;
    [SerializeField]
    private GameObject ind2;

    [Header("~~~~~~~~~~~~~~Miami~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject M_C;
    [SerializeField] private GameObject M_A;
    [SerializeField] private GameObject M_N;

    [Header("~~~~~~~~~~~~~~InBetween~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject N_A;
    [SerializeField] private GameObject A_C;
    [SerializeField] private GameObject A_R;
    [SerializeField] private GameObject A_N;
    [SerializeField] private GameObject C_R;
    [SerializeField] private GameObject R_W;
    [SerializeField] private GameObject R_P;
    [SerializeField] private GameObject P_N;
    [SerializeField] private GameObject W_N;
    [SerializeField] private GameObject P_T;
    [SerializeField] private GameObject T_M;
    [SerializeField] private GameObject M_B;

    [Header("~~~~~~~~~~~~~~Boston~~~~~~~~~~~~~~~")]
    [SerializeField] private GameObject N_B;
    [SerializeField] private GameObject B_N;
    bool isActive = false;

    public GameObject destroyThis;

    void Update()
    {
        RouteComplete();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //this the state of these gameObjects and toggle them on and off based on their current state
        isActive = !isActive;
        
        ind1.SetActive(isActive);
        ind2.SetActive(isActive);
    }

    private void RouteComplete()
    {
        if((M_C.activeSelf ||  M_A.activeSelf ||M_N.activeSelf) &&(A_C.activeSelf || A_R.activeSelf ) || (A_C.activeSelf|| A_N.activeSelf )||( C_R.activeSelf || R_W.activeSelf || R_P.activeSelf || P_N.activeSelf || W_N.activeSelf || P_T.activeSelf || T_M.activeSelf || M_B.activeSelf)&& (N_B.activeSelf || B_N.activeSelf))
        {
            if(destroyThis.activeSelf)
            {
                Destroy(destroyThis.gameObject);
            }
            
        }
    }
}

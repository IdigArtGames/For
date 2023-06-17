using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    //refs
    public PlayerSO playerSO;
    public PlayerInDetail playerInDetail;
    void Start()
    {
        playerSO.PlayerTrainCars = 45;
        playerSO.PlayerScore = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AllPlayer1Cards : MonoBehaviour
{
    public BoxSlot boxSlot;
    public CabooseSlot cabooseSlot;
    public FreightSlot freightSlot;
    public CoalSlot coalSlot;
    public ReeferSlot reeferSlot;
    public PassengerSlot passengerSlot; 
    public WildCardSlot wildCardSlot;
    public TankerSlot tankerSlot;
    public HopperSlot hopperSlot;

    public JustToTest justToTest;

    public TMP_Text totalTxt;
    private bool hasExecuted = false;
    private int Total;
    void Start()
    {
        Total = 0;
    }
    void Update()
    {
        Total = boxSlot.amountOfBoxTrain + cabooseSlot.amountOfBoxTrain + freightSlot.amountOfBoxTrain + coalSlot.amountOfBoxTrain + reeferSlot.amountOfBoxTrain + passengerSlot.amountOfBoxTrain + wildCardSlot.amountOfBoxTrain + tankerSlot.amountOfBoxTrain + hopperSlot.amountOfBoxTrain;
        totalTxt.text = Total.ToString();

        if (Total == 4 && !hasExecuted)
        {
            justToTest.Change();
            hasExecuted = true;
        }
    }


}

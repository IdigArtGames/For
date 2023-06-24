using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//this script keeps tracks of the current total of TrainCards the player2 has
//
public class AllPlayer2Cards : MonoBehaviour
{
    //ref to all the scripts attached to player2 slots
    public BoxSlot boxSlot;
    public CabooseSlot cabooseSlot;
    public FreightSlot freightSlot;
    public CoalSlot coalSlot;
    public ReeferSlot reeferSlot;
    public PassengerSlot passengerSlot;
    public WildCardSlot wildCardSlot;
    public TankerSlot tankerSlot;
    public HopperSlot hopperSlot;

    //ref to justToTest class
    public JustToTest justToTest;

    //Text mesh Pro to display the total
    public TMP_Text totalTxt;

    //int
    private int Total;
    //a bool to flag if anything inside the if statement on the update method has been executed 
    private bool hasExecuted = false;

    public Button turnManager;

    public GameObject disableThisButton;
    // Start is called before the first frame update
    void Start()
    {   //initial Total value
        Total = 0;
    }

    

    void Update()
    {
        // sum of all the amount all these slots holds
        Total = boxSlot.amountOfBoxTrain + cabooseSlot.amountOfBoxTrain + freightSlot.amountOfBoxTrain + coalSlot.amountOfBoxTrain + reeferSlot.amountOfBoxTrain + passengerSlot.amountOfBoxTrain + wildCardSlot.amountOfBoxTrain + tankerSlot.amountOfBoxTrain + hopperSlot.amountOfBoxTrain;
        // converts the int value into a string so it can be displayed over a text
        totalTxt.text = Total.ToString();

        //checks if the Total is equal to 4 and what's inside the if statement hasn't been executed before 
        if (Total == 4 && !hasExecuted)
        {
            //calls the change method from the JustToTest class
            justToTest.Change();
            //this bool flags that everything inside did get executed so that it won't get executed ever again
            hasExecuted = true;
            //this will disable the referenced gameObject
            disableThisButton.SetActive(false);
            // this will enable the turnManager button component to be interactable 
            turnManager.interactable = true;
        }
    }

}

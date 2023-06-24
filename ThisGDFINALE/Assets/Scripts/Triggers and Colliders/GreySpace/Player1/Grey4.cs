using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grey4 : MonoBehaviour
{
    //refs
    public PlayerSO playerSO;
    public PlayerInDetail playerInDetail;
    public FreightSlot freightSlot;
    public BoxSlot boxSlot;
    public PassengerSlot passengerSlot;
    public ReeferSlot reeferSlot;
    public TankerSlot tankerSlot;
    public CabooseSlot cabooseSlot;
    public HopperSlot hopperSlot;
    public CoalSlot coalSlot;
    public WildCardSlot wildCardSlot;
    private JustToTest toTest;

    //GameObjects
    public GameObject trainOnBoard;
    public GameObject theTrigger;
    private GameObject triggeredObject;

    //bool
    private bool isTriggered = false;

    private BoxCollider2D bc;
    //Ponits and TrainCras
    private int AddPoints = 15;
    private int SubtractTrainCars = 6;
    private int RequiredTrainCards = 5;

    public void forTanker()
    {
        int required = RequiredTrainCards - tankerSlot.amountOfBoxTrain;
        int total = required;

        int Total = required;
        int count = 0;
        for (int i = 0; i < wildCardSlot.transform.childCount; i++)
        {
            if (tankerSlot.amountOfBoxTrain <= RequiredTrainCards)
            {
                Destroy(wildCardSlot.transform.GetChild(i).gameObject);

                count++;

                if (count >= total)
                    break;
            }

        }
    }

    public void forPassenger()
    {
        int required = RequiredTrainCards - passengerSlot.amountOfBoxTrain;
        int total = required;

        int Total = required;
        int count = 0;
        for (int i = 0; i < wildCardSlot.transform.childCount; i++)
        {
            if (passengerSlot.amountOfBoxTrain <= RequiredTrainCards)
            {
                Destroy(wildCardSlot.transform.GetChild(i).gameObject);

                count++;

                if (count >= total)
                    break;
            }

        }
    }

    public void forFreight()
    {
        int required = RequiredTrainCards - freightSlot.amountOfBoxTrain;
        int total = required;

        int Total = required;
        int count = 0;
        for (int i = 0; i < wildCardSlot.transform.childCount; i++)
        {
            if (freightSlot.amountOfBoxTrain <= RequiredTrainCards)
            {
                Destroy(wildCardSlot.transform.GetChild(i).gameObject);

                count++;

                if (count >= total)
                    break;
            }

        }
    }

    public void forBox()
    {
        int required = RequiredTrainCards - boxSlot.amountOfBoxTrain;
        int total = required;

        int Total = required;
        int count = 0;
        for (int i = 0; i < wildCardSlot.transform.childCount; i++)
        {
            if (boxSlot.amountOfBoxTrain <= RequiredTrainCards)
            {
                Destroy(wildCardSlot.transform.GetChild(i).gameObject);

                count++;

                if (count >= total)
                    break;
            }

        }
    }

    public void forReefer()
    {
        int required = RequiredTrainCards - reeferSlot.amountOfBoxTrain;
        int total = required;

        int Total = required;
        int count = 0;
        for (int i = 0; i < wildCardSlot.transform.childCount; i++)
        {
            if (reeferSlot.amountOfBoxTrain <= RequiredTrainCards)
            {
                Destroy(wildCardSlot.transform.GetChild(i).gameObject);

                count++;

                if (count >= total)
                    break;
            }

        }
    }

    public void forCaboose()
    {
        int required = RequiredTrainCards - cabooseSlot.amountOfBoxTrain;
        int total = required;

        int Total = required;
        int count = 0;
        for (int i = 0; i < wildCardSlot.transform.childCount; i++)
        {
            if (cabooseSlot.amountOfBoxTrain <= RequiredTrainCards)
            {
                Destroy(wildCardSlot.transform.GetChild(i).gameObject);

                count++;

                if (count >= total)
                    break;
            }

        }
    }

    public void forHopper()
    {
        int required = RequiredTrainCards - hopperSlot.amountOfBoxTrain;
        int total = required;

        int Total = required;
        int count = 0;
        for (int i = 0; i < wildCardSlot.transform.childCount; i++)
        {
            if (hopperSlot.amountOfBoxTrain <= RequiredTrainCards)
            {
                Destroy(wildCardSlot.transform.GetChild(i).gameObject);

                count++;

                if (count >= total)
                    break;
            }

        }
    }

    public void forCoal()
    {
        int required = RequiredTrainCards - coalSlot.amountOfBoxTrain;
        int total = required;

        int Total = required;
        int count = 0;
        for (int i = 0; i < wildCardSlot.transform.childCount; i++)
        {
            if (coalSlot.amountOfBoxTrain <= RequiredTrainCards)
            {
                Destroy(wildCardSlot.transform.GetChild(i).gameObject);

                count++;

                if (count >= total)
                    break;
            }

        }
    }

    private void Start()
    {
        toTest = FindObjectOfType<JustToTest>();
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Freight") || collision.gameObject.CompareTag("WildCard") || collision.gameObject.CompareTag("Box") || collision.gameObject.CompareTag("Coal") || collision.gameObject.CompareTag("Passenger") || collision.gameObject.CompareTag("Caboose") || collision.gameObject.CompareTag("Reefer") || collision.gameObject.CompareTag("Tanker") || collision.gameObject.CompareTag("Hopper"))
        {
            print("Collided");
            trainOnBoard.SetActive(true);
            isTriggered = true;
            triggeredObject = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Freight") || collision.gameObject.CompareTag("WildCard") || collision.gameObject.CompareTag("Box") || collision.gameObject.CompareTag("Coal") || collision.gameObject.CompareTag("Passenger") || collision.gameObject.CompareTag("Caboose") || collision.gameObject.CompareTag("Reefer") || collision.gameObject.CompareTag("Tanker") || collision.gameObject.CompareTag("Hopper"))
        {
            trainOnBoard.SetActive(false);
            isTriggered = false;
        }
    }

    private void Update()
    {
        if (isTriggered && Input.GetMouseButtonUp(0))
        {
            if (triggeredObject.CompareTag("Box") && boxSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("Hopper") && wildCardSlot.amountOfBoxTrain + hopperSlot.amountOfBoxTrain >= RequiredTrainCards) ||(triggeredObject.CompareTag("Caboose") && wildCardSlot.amountOfBoxTrain + cabooseSlot.amountOfBoxTrain >= RequiredTrainCards) ||(triggeredObject.CompareTag("Tanker") && wildCardSlot.amountOfBoxTrain + tankerSlot.amountOfBoxTrain >= RequiredTrainCards) ||(triggeredObject.CompareTag("Reefer") && wildCardSlot.amountOfBoxTrain + reeferSlot.amountOfBoxTrain >= RequiredTrainCards) || (triggeredObject.CompareTag("Passenger") && wildCardSlot.amountOfBoxTrain + passengerSlot.amountOfBoxTrain >= RequiredTrainCards) || (triggeredObject.CompareTag("Coal") && wildCardSlot.amountOfBoxTrain + coalSlot.amountOfBoxTrain >= RequiredTrainCards) || (triggeredObject.CompareTag("Box") && wildCardSlot.amountOfBoxTrain + boxSlot.amountOfBoxTrain >= RequiredTrainCards) || (triggeredObject.CompareTag("Freight") && wildCardSlot.amountOfBoxTrain + freightSlot.amountOfBoxTrain >= RequiredTrainCards) || (triggeredObject.CompareTag("Hopper") && hopperSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("Coal") && coalSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("Tanker") && tankerSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("Reefer") && reeferSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("Caboose") && cabooseSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("Passenger") && passengerSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("Freight") && freightSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("WildCard") && wildCardSlot.amountOfBoxTrain >= RequiredTrainCards)))))))))
            {
                //we want to only destroy the BoxCards because it is what triggered the collision
                if (triggeredObject.CompareTag("Freight") || triggeredObject.CompareTag("Freight") && wildCardSlot.amountOfBoxTrain+ freightSlot.amountOfBoxTrain >= RequiredTrainCards)
                {

                    if(freightSlot.amountOfBoxTrain <= RequiredTrainCards)
                    {
                        forFreight();
                    }
                    int count = 0;

                    for (int i = 0; i < freightSlot.transform.childCount; i++)
                    {
                        Destroy(freightSlot.transform.GetChild(i).gameObject);

                        count++;

                        if (count >= RequiredTrainCards)
                            break;
                    }
                }

                if (triggeredObject.CompareTag("Box") || triggeredObject.CompareTag("Box") && wildCardSlot.amountOfBoxTrain + boxSlot.amountOfBoxTrain >= RequiredTrainCards)
                {

                    if (boxSlot.amountOfBoxTrain <= RequiredTrainCards)
                    {
                        forBox();
                    }
                    int count = 0;

                    for (int i = 0; i < boxSlot.transform.childCount; i++)
                    {
                        Destroy(boxSlot.transform.GetChild(i).gameObject);

                        count++;

                        if (count >= RequiredTrainCards)
                            break;
                    }
                }

                if (triggeredObject.CompareTag("Coal") || triggeredObject.CompareTag("Coal") && wildCardSlot.amountOfBoxTrain + coalSlot.amountOfBoxTrain >= RequiredTrainCards)
                {
                    if (coalSlot.amountOfBoxTrain <= RequiredTrainCards)
                    {
                        forCoal();
                    }
                    int count = 0;

                    for (int i = 0; i < coalSlot.transform.childCount; i++)
                    {
                        Destroy(coalSlot.transform.GetChild(i).gameObject);

                        count++;

                        if (count >= RequiredTrainCards)
                            break;
                    }
                }

                if (triggeredObject.CompareTag("Passenger") || triggeredObject.CompareTag("Passenger") && wildCardSlot.amountOfBoxTrain + passengerSlot.amountOfBoxTrain >= RequiredTrainCards)
                {
                    if (passengerSlot.amountOfBoxTrain <= RequiredTrainCards)
                    {
                        forPassenger();
                    }
                    int count = 0;

                    for (int i = 0; i < passengerSlot.transform.childCount; i++)
                    {
                        Destroy(passengerSlot.transform.GetChild(i).gameObject);

                        count++;

                        if (count >= RequiredTrainCards)
                            break;
                    }
                }
                if (triggeredObject.CompareTag("Reefer") || triggeredObject.CompareTag("Reefer") && wildCardSlot.amountOfBoxTrain + reeferSlot.amountOfBoxTrain >= RequiredTrainCards)
                {
                    if (reeferSlot.amountOfBoxTrain <= RequiredTrainCards)
                    {
                        forReefer();
                    }
                    int count = 0;

                    for (int i = 0; i < reeferSlot.transform.childCount; i++)
                    {
                        Destroy(reeferSlot.transform.GetChild(i).gameObject);

                        count++;

                        if (count >= RequiredTrainCards)
                            break;
                    }
                }

                if (triggeredObject.CompareTag("Tanker") || triggeredObject.CompareTag("Tanker") && wildCardSlot.amountOfBoxTrain + tankerSlot.amountOfBoxTrain >= RequiredTrainCards)
                {
                    if (tankerSlot.amountOfBoxTrain <= RequiredTrainCards)
                    {
                        forTanker();
                    }
                    int count = 0;

                    for (int i = 0; i < tankerSlot.transform.childCount; i++)
                    {
                        Destroy(tankerSlot.transform.GetChild(i).gameObject);

                        count++;

                        if (count >= RequiredTrainCards)
                            break;
                    }
                }

                if (triggeredObject.CompareTag("Caboose") || triggeredObject.CompareTag("Caboose") && wildCardSlot.amountOfBoxTrain + cabooseSlot.amountOfBoxTrain >= RequiredTrainCards)
                {
                    if (cabooseSlot.amountOfBoxTrain <= RequiredTrainCards)
                    {
                        forCaboose();
                    }
                    int count = 0;

                    for (int i = 0; i < cabooseSlot.transform.childCount; i++)
                    {
                        Destroy(cabooseSlot.transform.GetChild(i).gameObject);

                        count++;

                        if (count >= RequiredTrainCards)
                            break;
                    }
                }

                if (triggeredObject.CompareTag("Hopper") || triggeredObject.CompareTag("Hopper") && wildCardSlot.amountOfBoxTrain + hopperSlot.amountOfBoxTrain >= RequiredTrainCards)
                {
                    if (hopperSlot.amountOfBoxTrain <= RequiredTrainCards)
                    {
                        forHopper();
                    }
                    int count = 0;

                    for (int i = 0; i < hopperSlot.transform.childCount; i++)
                    {
                        Destroy(hopperSlot.transform.GetChild(i).gameObject);

                        count++;

                        if (count >= RequiredTrainCards)
                            break;
                    }
                }


                //we want to only destroy the wildCards because it is what triggered the collision
                if (triggeredObject.CompareTag("WildCard"))
                {
                    int count = 0;

                    for (int i = 0; i < wildCardSlot.transform.childCount; i++)
                    {
                        Destroy(wildCardSlot.transform.GetChild(i).gameObject);

                        count++;

                        if (count >= RequiredTrainCards)
                            break;
                    }
                }

                //this is the card that we dragged into the trigger
                Destroy(triggeredObject);
                toTest.Change();
                trainOnBoard.SetActive(true);
                bc.gameObject.SetActive(false);
                //AddPoints
                playerSO.PlayerScore += AddPoints;
                playerInDetail.PlayerScore.text = playerSO.PlayerScore.ToString();
                //Minus Trains
                playerSO.PlayerTrainCars -= SubtractTrainCars;
                playerInDetail.PlayerTrainCar.text = playerSO.PlayerTrainCars.ToString();
            }
        }
    }
}

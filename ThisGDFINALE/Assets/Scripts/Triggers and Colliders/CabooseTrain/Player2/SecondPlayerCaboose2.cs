using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerCaboose2 : MonoBehaviour
{
    //refs
    public PlayerSO playerSO;
    public PlayerInDetail playerInDetail;
    public CabooseSlot cabooseSlot;
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

    public void just()
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

    private void Start()
    {
        toTest = FindObjectOfType<JustToTest>();
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Caboose") || collision.gameObject.CompareTag("WildCard"))
        {


            print("Collided");
            trainOnBoard.SetActive(true);
            isTriggered = true;
            triggeredObject = collision.gameObject;


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Caboose") || collision.gameObject.CompareTag("WildCard"))
        {
            trainOnBoard.SetActive(false);
            isTriggered = false;
        }
    }

    private void Update()
    {
        if (isTriggered && Input.GetMouseButtonUp(0))
        {
            if (((triggeredObject.CompareTag("Caboose")) && cabooseSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("Caboose") && wildCardSlot.amountOfBoxTrain + cabooseSlot.amountOfBoxTrain >= RequiredTrainCards) || ((triggeredObject.CompareTag("WildCard")) && wildCardSlot.amountOfBoxTrain >= RequiredTrainCards)))
            {
                //we want to only destroy the BoxCards because it is what triggered the collision
                if (triggeredObject.CompareTag("Caboose") || triggeredObject.CompareTag("Caboose") && wildCardSlot.amountOfBoxTrain + cabooseSlot.amountOfBoxTrain >= RequiredTrainCards)
                {
                    int count = 0;

                    if (cabooseSlot.amountOfBoxTrain < RequiredTrainCards)
                    {
                        just();
                    }

                    for (int i = 0; i < cabooseSlot.transform.childCount; i++)
                    {
                        Destroy(cabooseSlot.transform.GetChild(i).gameObject);

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

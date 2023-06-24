using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SecondPlayerTanker1 : MonoBehaviour
{
    //refs
    public PlayerSO playerSO;
    public PlayerInDetail playerInDetail;
    public TankerSlot tankerSlot;
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
    private int AddPoints = 4;
    private int SubtractTrainCars = 3;
    private int RequiredTrainCards = 2;

    public void just()
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

    private void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        toTest = FindObjectOfType<JustToTest>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tanker") || collision.gameObject.CompareTag("WildCard"))
        {

            
                print("Collided");
                trainOnBoard.SetActive(true);
                isTriggered = true;
                triggeredObject = collision.gameObject;
            

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tanker") || collision.gameObject.CompareTag("WildCard"))
        {
            trainOnBoard.SetActive(false);
            isTriggered = false;
        }
    }

    private void Update()
    {
        if (isTriggered && Input.GetMouseButtonUp(0))
        {
            if (((triggeredObject.CompareTag("Tanker")) && tankerSlot.amountOfBoxTrain >= RequiredTrainCards || (triggeredObject.CompareTag("Tanker") && wildCardSlot.amountOfBoxTrain + tankerSlot.amountOfBoxTrain >= RequiredTrainCards) || ((triggeredObject.CompareTag("WildCard")) && wildCardSlot.amountOfBoxTrain >= RequiredTrainCards)))
            {
                //we want to only destroy the BoxCards because it is what triggered the collision
                if (triggeredObject.CompareTag("Tanker") || triggeredObject.CompareTag("Tanker") && wildCardSlot.amountOfBoxTrain + tankerSlot.amountOfBoxTrain >= RequiredTrainCards)
                {
                    int count = 0;

                    if (tankerSlot.amountOfBoxTrain < RequiredTrainCards)
                    {
                        just();
                    }

                    for (int i = 0; i < tankerSlot.transform.childCount; i++)
                    {
                        Destroy(tankerSlot.transform.GetChild(i).gameObject);

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

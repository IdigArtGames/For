using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SecondPlayerCoal1 : MonoBehaviour
{
    //refs
    public PlayerSO playerSO;
    public PlayerInDetail playerInDetail;
    public CoalSlot coalSlot;
    public WildCardSlot wildCardSlot;
    public TankerTrain3 tankerTrain3;
    private JustToTest toTest;

    //GameObjects
    public GameObject trainOnBoard;
    public GameObject theTrigger;
    private GameObject triggeredObject;

    //bool
    private bool isTriggered = false;

    public BoxCollider2D bc;
    //Ponits and TrainCras
    private int AddPoints = 7;
    private int SubtractTrainCars = 4;
    private int RequiredTrainCards = 3;

    private void Start()
    {
        toTest = FindObjectOfType<JustToTest>();
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coal") || collision.gameObject.CompareTag("WildCard"))
        {
                print("Collided");
                trainOnBoard.SetActive(true);
                isTriggered = true;
                triggeredObject = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coal") || collision.gameObject.CompareTag("WildCard"))
        {
            trainOnBoard.SetActive(false);
            isTriggered = false;
        }
    }

    private void Update()
    {
        if (isTriggered && Input.GetMouseButtonUp(0) && tankerTrain3.bc.isActiveAndEnabled)
        {
            if (((triggeredObject.CompareTag("Coal")) && coalSlot.amountOfBoxTrain >= RequiredTrainCards || ((triggeredObject.CompareTag("WildCard")) && wildCardSlot.amountOfBoxTrain >= RequiredTrainCards)))
            {
                //we want to only destroy the BoxCards because it is what triggered the collision
                if (triggeredObject.CompareTag("Coal"))
                {
                    int count = 0;

                    for (int i = 0; i < coalSlot.transform.childCount; i++)
                    {
                        Destroy(coalSlot.transform.GetChild(i).gameObject);

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

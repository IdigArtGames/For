using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grey2 : MonoBehaviour
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
    private int AddPoints = 1;
    private int SubtractTrainCars = 1;

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

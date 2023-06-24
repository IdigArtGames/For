using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfHasDrawn : MonoBehaviour

    // This script will be used to check if a player has drawn cards, 
    // if that returns true
    // it then would be the other player's turn and just like player1,
    // Once player2 draws two cards from the deck, their turn will end and back to player1 again and so on...
{
    //initial Clicks
    private int Clicks = 0;
    //ref to button
    [SerializeField]private Button drawButton;

    //ref to JustToTest class
    private JustToTest toTest;

    public GameObject toBeDestroyed;
    void Start()
    {
        //we set the drawButton to false on start
        drawButton.interactable = false;
        //we want to get the JustToTest, so we can reference its methods... we use 'find' instead of 'get' because the class is private 
        toTest = FindObjectOfType<JustToTest>();
        //we want to listen when the button is clicked
        drawButton.onClick.AddListener(IncreaseClicks);
    }

    public void IncreaseClicks()
    {
        // whenever this method is called we will increament the number of clicks
        Clicks++;
        //a debug log
        Debug.Log("Button Clicked " + Clicks + " times.");
        //if clicks are greater than or equal to 2...
        if (Clicks >= 2)
        {
            //we call the Change() method from the JustToTest class
            toTest.Change();
            //we call the ResetClicks method inside this if statement so that when the number of clicks is equal to || greater than 2, the method will reset it back to 0
            ResetClicks();
        }
    }

    private void ResetClicks()
    {
        //reset to 0
        Clicks = 0;
        //just a debug to test if it actually works
        Debug.Log(Clicks);
    }
}

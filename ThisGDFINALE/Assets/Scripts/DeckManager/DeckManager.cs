using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> discardPile = new List<Card>();
    public Transform[] player1CardSlots;
    public Transform[] player2CardSlots;
    public bool[] isSlotAvailable;


    public GameObject player1Cards;
    public GameObject player2Cards;

    public void DrawCards()
    {
        if (deck.Count >= 1)
        {
            Card randCard = deck[Random.Range(0,deck.Count)];
            for (int i = 0; i < isSlotAvailable.Length; i++)
            {
                if (isSlotAvailable[i] == true && randCard.CompareTag(player1CardSlots[i].tag))
                {  
                    if(player1Cards.activeSelf)
                    { 
                        randCard.gameObject.SetActive(true);
                        randCard.transform.SetParent(player1CardSlots[i].transform);
                        randCard.transform.localPosition = Vector3.zero;
                        isSlotAvailable[i] = true;
                        deck.Remove(randCard);
                        deck.TrimExcess();
                        return;
                    }

                }

                if (isSlotAvailable[i] == true && randCard.CompareTag(player2CardSlots[i].tag))
                {

                    if (player2Cards.activeSelf)
                    {
                        randCard.gameObject.SetActive(true);
                        randCard.transform.SetParent(player2CardSlots[i].transform);
                        randCard.transform.localPosition = Vector3.zero;
                        isSlotAvailable[i] = true;
                        deck.Remove(randCard);
                        deck.TrimExcess();
                        return;
                    }

                }
            }
        }
    }

    private void ReturnToDeck()
    {
        int numCardsToAdd = Mathf.Min(discardPile.Count, 110);
        for (int i = 0; i < numCardsToAdd; i++)
        {
            Card card = discardPile[i];
            if(card == null)
            {
                continue;
            }
                
            deck.Add(card);
        }

        discardPile.RemoveRange(0, numCardsToAdd);
        discardPile.TrimExcess();
    }





    void Update()
    {
        if(deck.Count == 0)
        {
            ReturnToDeck();
            deck.TrimExcess();
            discardPile.TrimExcess();
        }
    }
}

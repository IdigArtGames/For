using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
{
    public List<DestCard> destCards = new List<DestCard>();
    public Transform[] player1DestSlots;
    public Transform[] player2DestSlots;
    public bool[] destSlotAvail;
    public bool[] destSlotAvail2;

    public GameObject playerDest1;
    public GameObject playerDest2;

    public void DrawDestCards()
    {
        if (destCards.Count >= 1)
        {
            DestCard destCard = destCards[Random.Range(0, destCards.Count)];
            Transform emptySlot = GetEmptySlot();
            if (emptySlot != null)
            {
                destCard.gameObject.SetActive(true);
                destCard.transform.SetParent(emptySlot);
                destCard.transform.localPosition = Vector3.zero;
                destCards.Remove(destCard);
            }
        }
    }

    private Transform GetEmptySlot()
    {
        for (int i = 0; i < destSlotAvail.Length; i++)
        {
            if (destSlotAvail[i] && playerDest1.activeSelf)
            {
                destSlotAvail[i] = false;
                return player1DestSlots[i].transform;
            }
        }

        for (int i = 0; i < destSlotAvail2.Length; i++)
        {
            if (destSlotAvail2[i] && playerDest2.activeSelf)
            {
                destSlotAvail2[i] = false;
                return player2DestSlots[i].transform;
            }
        }

        return null; // No empty slots available
    }

    void Update()
    {
        
    }
}

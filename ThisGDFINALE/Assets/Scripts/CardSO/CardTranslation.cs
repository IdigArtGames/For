using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardTranslation : MonoBehaviour
{
    public CardSO card;
    public TMP_Text noOfCards;
    void Start()
    {
        noOfCards.text = card.noOfCards.ToString();
    }
}


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FreightSlot : MonoBehaviour
{
    public TMP_Text boxTrainTxt;
    public int amountOfBoxTrain;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Freight"))
        {
            amountOfBoxTrain++;
            boxTrainTxt.text = amountOfBoxTrain.ToString();
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Freight"))
        {
            amountOfBoxTrain--;
            boxTrainTxt.text = amountOfBoxTrain.ToString();
        }
    }

    private void Update()
    {
        if (amountOfBoxTrain <= 2)
        {
            boxTrainTxt.gameObject.SetActive(false);
        }

        if (amountOfBoxTrain >= 2)
        {
            boxTrainTxt.gameObject.SetActive(true);
        }
    }
}

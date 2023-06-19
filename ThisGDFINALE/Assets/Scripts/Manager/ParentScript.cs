using UnityEngine;

public class ParentScript : MonoBehaviour
{
    [Header("~~~~~~~~~~~~~~~~BoxTrains~~~~~~~~~~~~~~~")] 
    public BoxTrain boxTrain;
    public SecondPlayerBox playerBox;

    [Header("~~~~~~~~~~~~~~~~FreightTrains~~~~~~~~~~~~~~~")]
    public FreightTrain freightTrain;
    public SecondPlayerFreight playerFreight;

    public void Box()
    {
        if (boxTrain != null && playerBox == null)
        {
            boxTrain.enabled = false;
            playerBox.enabled = true;
        }
        else if (playerBox != null && boxTrain != null)
        {
            bool isScript1Active = boxTrain.enabled;
            boxTrain.enabled = !isScript1Active;
            playerBox.enabled = isScript1Active;
        }
    }

    public void Freight()
    {
        if (freightTrain != null && playerFreight == null)
        {
            freightTrain.enabled = false;
            playerFreight.enabled = true;
        }
        else if (playerFreight != null && freightTrain != null)
        {
            bool isScript1Active = freightTrain.enabled;
            freightTrain.enabled = !isScript1Active;
            playerFreight.enabled = isScript1Active;
        }
    }

}

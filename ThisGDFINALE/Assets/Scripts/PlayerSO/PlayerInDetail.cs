using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInDetail : MonoBehaviour
{
    //Ref
    public PlayerSO playerSO;
    //Texts
    public TMP_Text PlayerID;
    public TMP_Text PlayerTrainCar;
    public TMP_Text PlayerScore;
    //Images
    public Image TrainCardIcon;
    public Image TrainCarIcon;
    public Image ScoreIcon;

    void Start()
    {
        //conversions[Strings && TMPTexts
        PlayerID.text = playerSO.PlayerID;
        PlayerTrainCar.text = playerSO.PlayerTrainCars.ToString();
        PlayerScore.text = playerSO.PlayerScore.ToString();
        //Conversions [Sprite + Images]
        TrainCardIcon.sprite = playerSO.TrainCardIcon;
        TrainCarIcon.sprite = playerSO.TrainCarIcon;
        ScoreIcon.sprite = playerSO.ScoreIcon;
    }
}

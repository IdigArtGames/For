using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "PlayerSO", menuName = "Player", order = 0)]
public class PlayerSO : ScriptableObject
{
    public string PlayerID;
    public Sprite TrainCardIcon;
    public Sprite TrainCarIcon;
    public Sprite ScoreIcon;
    public int PlayerTrainCars;
    public int PlayerScore;
}

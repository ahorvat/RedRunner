using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : Observer
{
    public override void Update()
    {
        string text = "100 Coins Achievement Unlocked!";
        Debug.Log("100 Coins Achievement Unlocked!");
        AT.AchievementObtained(text);
    }
}
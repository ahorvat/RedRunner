using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : Observer
{
    public override void Update()
    {
        Debug.Log("100 Coins Achievement Unlocked!");
    }
}

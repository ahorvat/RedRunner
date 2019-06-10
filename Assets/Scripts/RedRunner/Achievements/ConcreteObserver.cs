using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteObserver : Observer
{
    private ConcreteAchievement _achievement;

    public ConcreteObserver(ConcreteAchievement achievement)
    {
        _achievement = achievement;
    }

    public override void Update()
    {
        Debug.Log("100 Coins!");
    }
}

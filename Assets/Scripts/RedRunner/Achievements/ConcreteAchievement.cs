using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteAchievement : AchievementBase
{
    private string _state;

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
}

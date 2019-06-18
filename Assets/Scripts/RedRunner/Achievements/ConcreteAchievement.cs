using RedRunner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteAchievement : BaseAchievement
{
    AchievementSystem AS = new AchievementSystem();
    public void checker()
    {
        if (GameManager.Singleton.m_Coin.Value >= 0)
        {
            Attach(AS);
            Notify();
            Detach(AS);
        }
    }
}
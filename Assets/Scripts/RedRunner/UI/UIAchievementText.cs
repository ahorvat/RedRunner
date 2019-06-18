using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedRunner.UI
{

    public class UIAchievementText : Text
    {

        protected override void Awake()
        {
            base.Awake();
        }

        public void AchievementObtained(string achievementText)
        {
            UIManager.Singleton.setAchievementText(achievementText);
        }

    }

}
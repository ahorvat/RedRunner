using RedRunner.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour
{
    public UIAchievementText AT = new UIAchievementText();
    public abstract void Update();
}
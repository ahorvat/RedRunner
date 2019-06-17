using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSound : Sound
{
    private static Singleton<WaterSound> _singleton;

    public WaterSound()
    {
        _singleton = new Singleton<WaterSound>(this);
    }

    public static WaterSound GetInstance()
    {
        return _singleton.GetInstance();
    }
}

public class SoundStrategy_Water : SoundStrategy
{
    public SoundStrategy_Water()
    {
        this._Sound = WaterSound.GetInstance();
    }

    public override void PlaySound()
    {
        _Sound.PlayNormalSound();
    }
}
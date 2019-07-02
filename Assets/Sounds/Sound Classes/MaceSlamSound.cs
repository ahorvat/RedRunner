using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceSlamSound : Sound
{
    private static Singleton<MaceSlamSound> _singleton;

    public MaceSlamSound()
    {
        _singleton = new Singleton<MaceSlamSound>(this);
    }

    public static MaceSlamSound GetInstance()
    {
        return _singleton.GetInstance();
    }
}

public class SoundStrategy_MaceSlam : SoundStrategy
{
    public SoundStrategy_MaceSlam()
    {
        this._Sound = MaceSlamSound.GetInstance();
    }

    public override void PlaySound()
    {
        _Sound.PlayNormalSound();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSound : Sound
{
    private static Singleton<SpikeSound> _singleton;

    public SpikeSound()
    {
        _singleton = new Singleton<SpikeSound>(this);
    }

    public static SpikeSound GetInstance()
    {
        return _singleton.GetInstance();
    }
}

public class SoundStrategy_Spike : SoundStrategy
{
    public SoundStrategy_Spike()
    {
        this._Sound = SpikeSound.GetInstance();
    }

    public override void PlaySound()
    {
        _Sound.PlayNormalSound();
    }
}

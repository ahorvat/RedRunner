using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : Sound
{
    private static Singleton<ClickSound> _singleton;

    public ClickSound()
    {
        _singleton = new Singleton<ClickSound>(this);
    }

    public static ClickSound GetInstance()
    {
        return _singleton.GetInstance();
    }
}

public class SoundStrategy_Click : SoundStrategy
{
    public SoundStrategy_Click()
    {
        this._Sound = ClickSound.GetInstance();
    }

    public override void PlaySound()
    {
        _Sound.PlayNormalSound();
    }
}

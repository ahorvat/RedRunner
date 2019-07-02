using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSound : Sound
{
    private static Singleton<ChestSound> _singleton;

    public ChestSound()
    {
        _singleton = new Singleton<ChestSound>(this);
    }

    public static ChestSound GetInstance()
    {
        return _singleton.GetInstance();
    }
}

public class SoundStrategy_Chest : SoundStrategy
{
    public SoundStrategy_Chest()
    {
        this._Sound = ChestSound.GetInstance();
    }

    public override void PlaySound()
    {
        _Sound.PlayNormalSound();
    }
}
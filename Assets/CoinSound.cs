using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : Sound
{ 
    private static Singleton<CoinSound> _singleton;

    public CoinSound()
    {
        _singleton = new Singleton<CoinSound>(this);
    }

    public static CoinSound GetInstance()
    {
        return _singleton.GetInstance();
    }
}

public class SoundStrategy_Coin : SoundStrategy
{
    public SoundStrategy_Coin()
    {
        this._Sound = CoinSound.GetInstance();
    }

    public override void PlaySound()
    {
        _Sound.PlayNormalSound();
    }
}

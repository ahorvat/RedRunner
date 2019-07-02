using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSound : Sound
{
    private static Singleton<MusicSound> _singleton;

    public MusicSound()
    {
        _singleton = new Singleton<MusicSound>(this);
    }

    public static MusicSound GetInstance()
    {
        return _singleton.GetInstance();
    }

}

public class SoundStrategy_Music : SoundStrategy
{
    public SoundStrategy_Music()
    {
        this._Sound = ChestSound.GetInstance();
    }

    public override void PlaySound()
    {
        _Sound.PlayNormalSound();
    }
}

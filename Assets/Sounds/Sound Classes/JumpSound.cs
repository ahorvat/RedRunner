using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : Sound
{
    private static Singleton<JumpSound> _singleton;

    public JumpSound()
    {
        _singleton = new Singleton<JumpSound>(this);
    }

    public static JumpSound GetInstance()
    {
        return _singleton.GetInstance();
    }
}

public class SoundStrategy_Jump : SoundStrategy
{
    public SoundStrategy_Jump()
    {
        this._Sound = JumpSound.GetInstance();
    }

    public override void PlaySound()
    {
        _Sound.PlayNormalSound();
    }
}

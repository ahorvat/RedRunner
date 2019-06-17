using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachGroundSound : Sound
{
    [SerializeField]
    private AudioClip[] _ReachGroundClips;

    private static Singleton<ReachGroundSound> _singleton;

    public ReachGroundSound()
    {
        _singleton = new Singleton<ReachGroundSound>(this);
    }

    public static ReachGroundSound GetInstance()
    {
        return _singleton.GetInstance();
    }

    public void ChooseRandomClip()
    {
        SetAudioClip(GetRandomClip(_ReachGroundClips));
    }
}

public class SoundStrategy_ReachGround : SoundStrategy
{
    public SoundStrategy_ReachGround()
    {
        this._Sound = ReachGroundSound.GetInstance();
    }

    public override void PlaySound()
    {
        ReachGroundSound.GetInstance().ChooseRandomClip();
        _Sound.PlayNormalSound();
    }
}

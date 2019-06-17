using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : Sound
{
    [SerializeField]
    private AudioClip[] _FootstepClips;

    private int _index;

    private static Singleton<FootstepSound> _singleton;

    public FootstepSound()
    {
        ResetClipSequence(ref _index);
        _singleton = new Singleton<FootstepSound>(this);
    }

    public static FootstepSound GetInstance()
    {
        return _singleton.GetInstance();
    }

    public void ChooseClipOnSequence()
    {
        SetAudioClip(GetClipOnSequence(_FootstepClips, ref _index));
    }

    public void ResetSettings()
    {
        ResetClipSequence(ref _index);
    }
}

public class SoundStrategy_Footstep : SoundStrategy
{
    public SoundStrategy_Footstep()
    {
        this._Sound = FootstepSound.GetInstance();
    }

    public override void PlaySound()
    {
        FootstepSound.GetInstance().ChooseClipOnSequence();
        _Sound.PlayNormalSound();
    }
}

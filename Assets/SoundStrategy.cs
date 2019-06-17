using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField]
    private AudioSource _AudioSource;
    [SerializeField]
    private AudioClip _AudioClip;

    public void PlayNormalSound()
    {
        if (_AudioSource != null && _AudioClip != null)
        {
            _AudioSource.clip = _AudioClip;
            _AudioSource.Play();
        }
    }

    public AudioSource GetAudioSource()
    {
        return _AudioSource;
    }

    public AudioClip GetAudioClip()
    {
        return _AudioClip;
    }
}

public abstract class SoundStrategy
{
    protected Sound _Sound = null;

    public abstract void PlaySound();
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

public class SoundStrategy_Water : SoundStrategy
{
    public SoundStrategy_Water()
    {
        this._Sound = DeathSound.GetInstance();
    }

    public override void PlaySound()
    {
        _Sound.PlayNormalSound();
    }
}
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

    public void SetAudioClip(AudioClip newClip)
    {
        _AudioClip = newClip;
    }
    
    public AudioClip GetRandomClip(AudioClip[] clips)
    {
        if (clips.Length > 0)
        {
            // Get a random clip from clips source
            return clips[Random.Range(0, clips.Length)];
        }
        return null;
    }

    public AudioClip GetClipOnSequence(AudioClip[] clips, ref int index)
    {
        if (clips.Length > 0)
        {
            // Get next clip on sequence
            AudioClip nextClip = clips[index];

            // Handle clip sequence
            if (index < clips.Length - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }

            return nextClip;
        }
        return null;
    }

    public void ResetClipSequence(ref int index)
    {
        index = 0;
    }
}

public abstract class SoundStrategy
{
    protected Sound _Sound = null;

    public abstract void PlaySound();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Basic sound class to swap between sound strategies
public class Sound : MonoBehaviour
{
    // Audio source is used to define where the sound comes from
    [SerializeField]
    private AudioSource _AudioSource;
    // Audio clip is the actual sound played
    // (when a Sound has more than one clip, they are stored privately)
    [SerializeField]
    private AudioClip _AudioClip;

    // Make audio source play audio clip
    public void PlayNormalSound()
    {
        if (_AudioSource != null && _AudioClip != null)
        {
            _AudioSource.clip = _AudioClip;
            _AudioSource.Play();
        }
    }

    // Change audio clip
    public void SetAudioClip(AudioClip newClip)
    {
        _AudioClip = newClip;
    }

    // Get a random clip from a collection of audio clips
    // (when a Sound has more than one clip)
    public AudioClip GetRandomClip(AudioClip[] clips)
    {
        if (clips.Length > 0)
        {
            // Get a random clip from clips source
            return clips[Random.Range(0, clips.Length)];
        }
        return null;
    }

    // Get a the next clip on a collection of audio clips (when sequence ends, repeat the sequence)
    // (when a Sound has more than one clip)
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

    // Reset sequence of audio clips
    // (when a Sound has more than one clip)
    public void ResetClipSequence(ref int index)
    {
        index = 0;
    }
}

// Base of sound strategy
public abstract class SoundStrategy
{
    protected Sound _Sound = null;

    public abstract void PlaySound();
}

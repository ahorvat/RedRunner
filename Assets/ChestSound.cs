using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSound : Sound
{
    //[SerializeField]
    //private AudioSource _AudioSource;
    //[SerializeField]
    //private AudioClip _AudioClip;

    private static Singleton<ChestSound> _singleton;

    public ChestSound()
    {
        _singleton = new Singleton<ChestSound>(this);
    }

    public static ChestSound GetInstance()
    {
        return _singleton.GetInstance();
    }

    //public AudioSource GetAudioSource()
    //{
    //    return _AudioSource;
    //}

    //public AudioClip GetAudioClip()
    //{
    //    return _AudioClip;
    //}
}

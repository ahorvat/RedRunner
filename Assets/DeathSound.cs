using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSound : Sound
{
    //[SerializeField]
    //private AudioSource _AudioSource;
    //[SerializeField]
    //private AudioClip _AudioClip;

    private static Singleton<DeathSound> _singleton;

    public DeathSound()
    {
        _singleton = new Singleton<DeathSound>(this);
    }

    public static DeathSound GetInstance()
    {
        return _singleton.GetInstance();
    }

    //public override AudioSource GetAudioSource()
    //{
    //    return _AudioSource;
    //}

    //public override AudioClip GetAudioClip()
    //{
    //    return _AudioClip;
    //}

}

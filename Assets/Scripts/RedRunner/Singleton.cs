using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> where T : class, new()
{
    private T _instance;

    public T GetInstance()
    {
        return _instance;
    }

    public Singleton(T place)
    {
        // Create Singleton
        if (_instance == null)
        {
            _instance = place;
        }
    }
}
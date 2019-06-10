using System;
using System.Collections;
using System.Collections.Generic;
using RedRunner;
using RedRunner.UI;
using UnityEngine;

public abstract class UIScreenState
{
    protected UIScreen _screen;

    public void OpenScreen()
    {
        if (_screen)
        {
            _screen.UpdateScreenStatus(true);
        }
    }

    public void CloseScreen()
    {
        if (_screen)
        {
            _screen.UpdateScreenStatus(false);
        }
    }
}

class GameState_Loading : UIScreenState
{
    public GameState_Loading()
    {
        this._screen = LoadingScreen.GetInstance();
    }
}

class GameState_Start : UIScreenState
{
    public GameState_Start()
    {
        this._screen = StartScreen.GetInstance();
    }
}

class GameState_End : UIScreenState
{
    public GameState_End()
    {
        this._screen = EndScreen.GetInstance();
    }
}

class GameState_Pause : UIScreenState
{
    public GameState_Pause()
    {
        this._screen = PauseScreen.GetInstance();
    }
}

class GameState_InGame : UIScreenState
{
    public GameState_InGame()
    {
        this._screen = InGameScreen.GetInstance();
    }
}

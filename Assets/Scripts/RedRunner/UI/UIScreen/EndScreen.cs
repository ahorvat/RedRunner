using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedRunner.UI
{
    public class EndScreen : UIScreen
    {
        [SerializeField]
        protected Button ResetButton = null;
        [SerializeField]
        protected Button HomeButton = null;
        [SerializeField]
        protected Button ExitButton = null;

        private void Start()
        {
            ResetButton.SetButtonAction(() =>
            {
                if (GameManager.Singleton.SaveState != Vector2.zero)
                {
                    Debug.Log("Quickload!");
                    GameManager.Singleton.m_QuickLoading = true;
                    GameManager.Singleton.Reset();
                    var ingameScreen = UIManager.Singleton.GetUIScreen(UIScreenInfo.IN_GAME_SCREEN);
                    UIManager.Singleton.OpenScreen(ingameScreen);
                    GameManager.Singleton.StartGame();
                }
                else
                {
                    Debug.Log("Slowloading.");
                    GameManager.Singleton.Reset();
                    var ingameScreen = UIManager.Singleton.GetUIScreen(UIScreenInfo.IN_GAME_SCREEN);
                    UIManager.Singleton.OpenScreen(ingameScreen);
                    GameManager.Singleton.StartGame();
                }
            });

            HomeButton.SetButtonAction(() =>
            {
                GameManager.Singleton.SaveState = Vector2.zero;
                GameManager.Singleton.Reset();
                var ingameScreen = UIManager.Singleton.GetUIScreen(UIScreenInfo.IN_GAME_SCREEN);
                UIManager.Singleton.OpenScreen(ingameScreen);
                GameManager.Singleton.StartGame();
            });

            ExitButton.SetButtonAction(() =>
            {

            });
        }

        public override void UpdateScreenStatus(bool open)
        {
            base.UpdateScreenStatus(open);
        }
    }

}
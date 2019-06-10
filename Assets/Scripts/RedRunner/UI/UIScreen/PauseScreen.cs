using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedRunner.UI
{
    public class PauseScreen : UIScreen
    {
        [SerializeField]
        protected Button ResumeButton = null;
        [SerializeField]
        protected Button HomeButton = null;
        [SerializeField]
        protected Button SoundButton = null;
        [SerializeField]
        protected Button ExitButton = null;

        private static Singleton<PauseScreen> _singleton;

        public PauseScreen()
        {
            _singleton = new Singleton<PauseScreen>(this);
        }

        public static PauseScreen GetInstance()
        {
            return _singleton.GetInstance();
        }

        private void Start()
        {
            ResumeButton.SetButtonAction(() =>
            {
                var uiManager = UIManager.Singleton;
                uiManager.TransitionTo(new GameState_InGame());
                GameManager.Singleton.StartGame();
            });

            HomeButton.SetButtonAction(() =>
            {
                var uiManager = UIManager.Singleton;
                uiManager.TransitionTo(new GameState_Start());
            });
        }

        public override void UpdateScreenStatus(bool open)
        {
            base.UpdateScreenStatus(open);
        }
    }
}

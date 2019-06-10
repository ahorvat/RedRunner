using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedRunner.UI
{
    public class InGameScreen : UIScreen
    {
        [SerializeField]
        protected Button PauseButton = null;

        [SerializeField]
        protected Button InfoButton = null;

        private static Singleton<InGameScreen> _singleton;

        public InGameScreen()
        {
            _singleton = new Singleton<InGameScreen>(this);
        }

        public static InGameScreen GetInstance()
        {
            return _singleton.GetInstance();
        }
       
        private void Start()
        {
            PauseButton.SetButtonAction(() =>
            {
                var uiManager = UIManager.Singleton;
                uiManager.TransitionTo(new GameState_Pause());
                GameManager.Singleton.StopGame();
            });
        }

        public override void UpdateScreenStatus(bool open)
        {
            base.UpdateScreenStatus(open);
        }
    }

}
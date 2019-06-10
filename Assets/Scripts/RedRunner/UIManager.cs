using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RedRunner.UI;
using System.Linq;

namespace RedRunner
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager m_Singleton;

        public static UIManager Singleton
        {
            get
            {
                return m_Singleton;
            }
        }

        private UIScreenState _gameState = null;

        private UIWindow m_ActiveWindow;
        [SerializeField]
        private Texture2D m_CursorDefaultTexture;
        [SerializeField]
        private Texture2D m_CursorClickTexture;
        [SerializeField]
        private float m_CursorHideDelay = 1f;

        void Awake()
        {
            // Create Singleton
            if (m_Singleton != null)
            {
                Destroy(gameObject);
                return;
            }
            m_Singleton = this;
            Cursor.SetCursor(m_CursorDefaultTexture, Vector2.zero, CursorMode.Auto);
        }

        public void TransitionTo(UIScreenState state)
        {
            this._gameState.CloseScreen();
            this._gameState = state;
            this._gameState.OpenScreen();
        }

        void Start()
        {
            this._gameState = new GameState_Loading();
            _gameState.OpenScreen();
        }

        void Update()
        {
            if (Input.GetButtonDown("Cancel"))
            {
                // If in game open pause screen
                if (!(_gameState is GameState_Pause))
                {
                    if(_gameState is GameState_InGame)
                    {
                        TransitionTo(new GameState_Pause());
                        GameManager.Singleton.StopGame();
                    }
                }
                else 
                {
                    // Resume Game
                    TransitionTo(new GameState_InGame());
                    GameManager.Singleton.ResumeGame();
                }
            }

            if (Input.GetMouseButtonDown(0))
            {
                Cursor.SetCursor(m_CursorClickTexture, Vector2.zero, CursorMode.Auto);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                Cursor.SetCursor(m_CursorDefaultTexture, Vector2.zero, CursorMode.Auto);
            }

        }

        public void OpenWindow(UIWindow window)
        {
            window.Open();
            m_ActiveWindow = window;
        }

        public void CloseWindow(UIWindow window)
        {
            if (m_ActiveWindow == window)
            {
                m_ActiveWindow = null;
            }
            window.Close();
        }

        public void CloseActiveWindow()
        {
            if (m_ActiveWindow != null)
            {
                CloseWindow(m_ActiveWindow);
            }
        }
    }

}
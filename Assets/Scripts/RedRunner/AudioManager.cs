using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedRunner
{

	public class AudioManager : MonoBehaviour
	{
        private SoundStrategy _SoundStrategy;

        #region Singleton

        private static AudioManager m_Singleton;

		public static AudioManager Singleton {
			get {
				return m_Singleton;
			}
		}

		#endregion

		#region MonoBehaviour Messages

		void Awake ()
		{
			m_Singleton = this;
        }

        void Start()
        {
            // Play music sound
            TriggerSound(new SoundStrategy_Music());
        }

        #endregion

        #region Methods

        // Set new sound strategy
        public void SetStrategy(SoundStrategy strategy)
        {
            _SoundStrategy = strategy;
        }

        // Change sound strategy and play it
        public void TriggerSound(SoundStrategy strategy)
        {
            SetStrategy(strategy);
            _SoundStrategy.PlaySound();
        }

		#endregion
	}

}
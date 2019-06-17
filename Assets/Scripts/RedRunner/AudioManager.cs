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

		#region Fields

		[Header ("Audio Sources")]
		[Space]
		[SerializeField]
		protected AudioSource m_MusicAudioSource;
		[SerializeField]
		protected AudioSource m_SoundAudioSource;
		[SerializeField]
		protected AudioSource m_CoinAudioSource;
		[SerializeField]
		protected AudioSource m_DieAudioSource;
		[SerializeField]
		protected AudioSource m_MaceSlamAudioSource;
		[SerializeField]
		protected AudioSource m_UIAudioSource;

		[Header ("Music Clips")]
		[Space]
		[SerializeField]
		protected AudioClip m_MusicClip;

		[Header ("Sound Clips")]
		[Space]
		[SerializeField]
		protected AudioClip m_CoinSound;
		[SerializeField]
		protected AudioClip m_ChestSound;
		[SerializeField]
		protected AudioClip m_WaterSplashSound;
		[SerializeField]
		protected AudioClip m_SpikeSound;
		[SerializeField]
		protected AudioClip[] m_GroundedSounds;
		[SerializeField]
		protected AudioClip m_JumpSound;
		[SerializeField]
		protected AudioClip[] m_FootstepSounds;
		[SerializeField]
		protected AudioClip m_MaceSlamSound;
		[SerializeField]
		protected AudioClip m_ButtonClickSound;

		#endregion

		#region MonoBehaviour Messages

		void Awake ()
		{
			m_Singleton = this;
			PlayMusic ();
        }

        void Start()
        {
            this._SoundStrategy = new SoundStrategy_Music();
        }

        #endregion

        #region Methods

        public void SetStrategy(SoundStrategy strategy)
        {
            _SoundStrategy = strategy;
        }

        public void PlaySoundAt(AudioClip clip, Vector3 position, float volume)
        {
            AudioSource.PlayClipAtPoint(clip, position, volume);
        }

        public void PlaySoundOn(AudioSource audio, AudioClip clip)
        {
            audio.clip = clip;
            audio.Play();
        }


        public void PlayMusic ()
		{
            //m_MusicAudioSource.clip = m_MusicClip;
            //m_MusicAudioSource.Play ();
            //PlaySoundOn(m_MusicAudioSource, m_MusicClip);
            SetStrategy(new SoundStrategy_Music());
            _SoundStrategy.PlaySound();
        }

		public void PlayChestSound (Vector3 position)
		{
			//PlaySoundOn (m_CoinAudioSource, m_ChestSound);
            SetStrategy(new SoundStrategy_Chest());
            _SoundStrategy.PlaySound();
        }

		public void PlayCoinSound (Vector3 position)
		{
            //PlaySoundOn (m_CoinAudioSource, m_CoinSound);
            SetStrategy(new SoundStrategy_Coin());
            _SoundStrategy.PlaySound();
        }

		public void PlayWaterSplashSound (Vector3 position)
		{
            SetStrategy(new SoundStrategy_Water());
            _SoundStrategy.PlaySound();
            //PlaySoundOn (m_DieAudioSource, m_WaterSplashSound);
        }

		public void PlayMaceSlamSound (Vector3 position)
		{
            //PlaySoundOn (m_MaceSlamAudioSource, m_MaceSlamSound);
            SetStrategy(new SoundStrategy_MaceSlam());
            _SoundStrategy.PlaySound();
        }

		public void PlaySpikeSound (Vector3 position)
		{
            //PlaySoundOn (m_DieAudioSource, m_SpikeSound);
            SetStrategy(new SoundStrategy_Spike());
            _SoundStrategy.PlaySound();
        }

		public void PlayGroundedSound (AudioSource audio)
		{
            //if (m_GroundedSounds.Length > 0) {
            //	PlaySoundOn (audio, GetRandomClip (m_GroundedSounds));
            //}
            SetStrategy(new SoundStrategy_ReachGround());
            _SoundStrategy.PlaySound();
        }

		public void PlayJumpSound (AudioSource audio)
		{
			//PlaySoundOn (audio, m_JumpSound);
            SetStrategy(new SoundStrategy_Jump());
            _SoundStrategy.PlaySound();
        }

        //not used
		public void PlayFootstepSound (AudioSource audio)
		{
			//if (m_FootstepSounds.Length > 0) {
			//	PlaySoundOn (audio, GetRandomClip (m_FootstepSounds));
			//}
		}

		public void PlayFootstepSound (AudioSource audio, ref int index)
		{
            //         if (m_FootstepSounds.Length > 0) {
            //	PlaySoundOn (audio, m_FootstepSounds [index]);
            //	if (index < m_FootstepSounds.Length - 1) {
            //		index++;
            //	} else {
            //		index = 0;
            //	}
            //}
            SetStrategy(new SoundStrategy_Footstep());
            _SoundStrategy.PlaySound();
        }

		public void PlayClickSound ()
		{
            //PlaySoundOn (m_UIAudioSource, m_ButtonClickSound);
            SetStrategy(new SoundStrategy_Click());
            _SoundStrategy.PlaySound();
        }

		public AudioClip GetRandomClip (AudioClip[] clips)
		{
			if (clips.Length > 0) {
				return clips [Random.Range (0, clips.Length)];
			}
			return null;
		}

		#endregion

	}

}
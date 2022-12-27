using UnityEngine;

namespace GTMY.Audio.Scripts
{
    internal class SetMusicPlayer : MonoBehaviour
    {
        [SerializeField] private MusicPlayerExplicit _music;
        [SerializeField] private float _musicVolume = 1f;

        private void Start()
        {
            AudioManagerSingleton.Instance.SetMusicPlayer(_music);
            AudioManagerSingleton.Instance.Music.Volume = _musicVolume;
        }
    }
}
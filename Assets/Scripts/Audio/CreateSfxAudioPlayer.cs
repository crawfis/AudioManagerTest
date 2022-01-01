using GTMY.Audio;
using UnityEngine;

namespace GTMY.Audio.Scripts
{
    /// <summary>
    /// A MonoBehaviour (Mainly for testing the AudioClipLibraryExplicit). It takes a AudioClipLibraryExplicit
    /// and two strings. One string defines the sfx audio player and is used when the same string is requested.
    /// The other string is associated with an already registered audio source, such as OneShot2D.
    /// </summary>
    public class CreateSfxAudioPlayer : MonoBehaviour
    {
        [SerializeField]
        private AudioClipLibaryExplicit audioClipProvider;
        [SerializeField]
        private string sfxType;
        [SerializeField]
        private string audioType;

        private IAudioClipProvider clipProvider;

        private void Start()
        {
            clipProvider = audioClipProvider.ClipProvider;
            ISfxAudioPlayer sfxAudioPlayer = SfxAudioPlayerFactory.Instance.CreateSfxAudioPlayer(sfxType, audioType, clipProvider);
        }
    }
}
using GTMY.Audio;
using UnityEngine;


namespace GTMY.Audio.Scripts
{
    /// <summary>
    /// MonoBehaviour (mainly used for testing) that loads in clips from addressables keys or labels (Intersection mode)
    /// and creates a ISfxAudioPlayer. The ISfxAUdioPlayer is then registered using the sfxType
    /// with the AudioManagerSingleton. The AudioSource is specified using a registered IAudio with
    /// the keyword audioType.
    /// </summary>
    public class CreateSfxAudioPlayerAddressables : MonoBehaviour
    {
        [SerializeField]
        private string[] labels;
        [SerializeField]
        private string sfxType;
        [SerializeField]
        private string audioType;

        private IAudioClipProvider clipProvider;

        private void Awake()
        {
            var addressablesClipProvider = new AudioClipProviderAddressablesPreLoaded(labels);
            addressablesClipProvider.LoadAllClipsAsync();
            clipProvider = addressablesClipProvider;
        }

        private void Start()
        {
            ISfxAudioPlayer sfxAudioPlayer = SfxAudioPlayerFactory.Instance.CreateSfxAudioPlayer(sfxType, audioType, clipProvider);
        }
    }
}
using UnityEngine;

namespace GTMY.Audio.Scripts
{
    public class InitializeAudioManager : MonoBehaviour
    {
        [SerializeField]
        private MusicPlayerExplicit Music;

        private async System.Threading.Tasks.Task Awake()
        {
            // Keep this instance alive
            DontDestroyOnLoad(this.gameObject);

            await UnityEngine.AddressableAssets.Addressables.Initialize().Task;
            AudioManagerSingleton.Instance.SetMusicPlayer(Music);
        }
    }
}

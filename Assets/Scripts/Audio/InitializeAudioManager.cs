using UnityEngine;

namespace GTMY.Audio.Scripts
{
    public class InitializeAudioManager : MonoBehaviour
    {
        private void Awake()
        {
            // Keep this instance alive
            DontDestroyOnLoad(this.gameObject);
            AudioManagerSingleton.Instance.MasterVolume = 0.8f;

            // If using Addressables can load a catalog here. This is obsolete, but still useful at times.
            UnityEngine.AddressableAssets.Addressables.Initialize();
        }
    }
}
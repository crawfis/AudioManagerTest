using UnityEngine;

namespace GTMY.Audio.Scripts
{
    /// <summary>
    /// MonoBehaviour (primarily for testing) to create an IAudioFactory using the GameObject
    /// that contains the specified AudioSource.
    /// </summary>
    public class RegisterAudioFactoryPrefabPooled : MonoBehaviour
    {
        [SerializeField]
        private string audioType;
        [SerializeField]
        private GameObject audioPrefab;

        private void Awake()
        {
            //foreach(var tuple in audioPrefabs)
            {
                var factory = new AudioFactoryPooled(this, audioPrefab);
                AudioFactoryRegistry.Instance.RegisterAudioFactory(audioType, factory);
            }
        }
    }
}
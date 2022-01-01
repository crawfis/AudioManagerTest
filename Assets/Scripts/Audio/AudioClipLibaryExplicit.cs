using UnityEngine;

namespace GTMY.Audio.Scripts
{
    /// <summary>
    /// A MonoBehaviour to illustrate a simple use-case of draggin AudioClips in the Unity Editor
    /// and wrapping them in a IAudioClipProvider. Uses AudioClipProvider with a new System.Random.
    /// </summary>
    public class AudioClipLibaryExplicit : MonoBehaviour
    {
        [SerializeField]
        private AudioClip[] clips;

        /// <summary>
        /// Get the IAudioClipProvider for these audio clips.
        /// </summary>
        public IAudioClipProvider ClipProvider { get; private set; }

        private void Awake()
        {
            var clipProvider = new AudioClipProvider(new System.Random());
            foreach(AudioClip clip in clips)
            {
                clipProvider.AddClip(clip);
            }
            ClipProvider = clipProvider;
        }
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace GTMY.Audio.Scripts
{
    /// <summary>
    /// MonoBehaviour (primarily for testing) to create an IAudioFactory using the GameObject
    /// that contains the specified AudioSource.
    /// </summary>
    public class RegisterAudioPrefabs : MonoBehaviour
    {
        [SerializeField]
        private string audioType;
        [SerializeField]
        private AudioSource audioPrefab;

        private void Awake()
        {
            //foreach(var tuple in audioPrefabs)
            {
                var factory = new AudioFactoryPrefab(audioPrefab, this);
                AudioFactoryRegistry.Instance.RegisterAudioFactory(audioType, factory);
            }
        }
    }
}
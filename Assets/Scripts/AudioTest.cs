using GTMY.Audio;
using GTMY.AudioTest;
using UnityEngine;

namespace GTMY.Audio.Scripts
{
    public class AudioTest : MonoBehaviour
    {
        const float volumeDelta = 0.05f;

        [SerializeField] private GameEventPublisher weaponFiredEvent;
        [SerializeField] private GameEventPublisher missleFiredEvent;

        private void Start()
        {
#if !UNITY_EDITOR
//PlayerPrefs.DeleteKey(Addressables.kAddressablesRuntimeDataPath);
#endif
            var actionMap = new GTMY.AudioTest.TestKeyboard();
            actionMap.Test.Enable();
            actionMap.Test.Quit.performed += (context) => Application.Quit();
            actionMap.Test.VolumeDown.performed += (context) => AudioManagerSingleton.Instance.MasterVolume -= volumeDelta;
            actionMap.Test.VolumeUp.performed += (context) => AudioManagerSingleton.Instance.MasterVolume += volumeDelta;
            actionMap.Test.Mute.performed += (context) => AudioManagerSingleton.Instance.Mute();
            actionMap.Test.UnMute.performed += (context) => AudioManagerSingleton.Instance.UnMute();
            actionMap.Test.CollisionOccured.performed += (context) => AudioManagerSingleton.Instance.PlaySfx("collision");
            actionMap.Test.MusicPlay.performed += (context) => AudioManagerSingleton.Instance.Music.Play();
            actionMap.Test.MusicStop.performed += (context) => AudioManagerSingleton.Instance.Music.Stop();
            actionMap.Test.MusicPause.performed += (context) => AudioManagerSingleton.Instance.Music.Pause();
            actionMap.Test.MusicUnpause.performed += (context) => AudioManagerSingleton.Instance.Music.UnPause();
            actionMap.Test.WeaponFired.performed += (context) => weaponFiredEvent.Raise(); // AudioManagerSingleton.Instance.PlaySfx("weapon");
            actionMap.Test.Explosion.performed += (context) => missleFiredEvent.Raise(); // AudioManagerSingleton.Instance.PlaySfx("explosion");
            actionMap.Test.SfxTest.performed += (context) => AudioManagerSingleton.Instance.PlaySfx("test");
        }
    }
}
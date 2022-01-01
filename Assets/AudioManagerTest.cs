using GTMY.Audio;
using UnityEngine;

public class AudioManagerTest : MonoBehaviour
{
    public AudioClip sfxClip;

    private void Update()
    {
        const float volumeDelta = 0.1f;
        if (Input.GetKeyDown(KeyCode.Alpha1))
            AudioManagerSingleton.Instance.MasterVolume -= volumeDelta;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            AudioManagerSingleton.Instance.MasterVolume += volumeDelta;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            AudioManagerSingleton.Instance.Mute();
        if (Input.GetKeyDown(KeyCode.Alpha4))
            AudioManagerSingleton.Instance.UnMute();
        //if (Input.GetKeyDown(KeyCode.Alpha5))
        //    AudioManagerSingleton.Instance.PlaySfx(sfxClip, 1);
        if (Input.GetKeyDown(KeyCode.Alpha6))
            AudioManagerSingleton.Instance.Music.Play();
        if (Input.GetKeyDown(KeyCode.Alpha7))
            AudioManagerSingleton.Instance.Music.Stop();
        if (Input.GetKeyDown(KeyCode.Alpha8))
            AudioManagerSingleton.Instance.Music.Pause();
        if (Input.GetKeyDown(KeyCode.Alpha9))
            AudioManagerSingleton.Instance.Music.UnPause();
    }
}
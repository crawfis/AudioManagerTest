using GTMY.Audio;
using UnityEngine;

namespace GTMY.AudioTest
{
    public class TestSfxManager : MonoBehaviour
    {
        public void PlayWeaponFiredSound()
        {
            AudioManagerSingleton.Instance.PlaySfx("weapon");
        }

        public void PlayMissleFiredSound()
        {
            AudioManagerSingleton.Instance.PlaySfx("explosion");
        }
    }
}
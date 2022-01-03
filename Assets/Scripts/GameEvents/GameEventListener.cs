using UnityEngine;
using UnityEngine.Events;

namespace GTMY.AudioTest
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField] private GameEventPublisher gameEvent;
        [SerializeField] private UnityEvent response;

        private void OnEnable()
        {
            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            gameEvent.UnRegisterListener(this);
        }

        public void OnEventRaised()
        {
            response.Invoke();
        }
    }
}
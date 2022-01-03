using System.Collections.Generic;
using UnityEngine;

namespace GTMY.AudioTest
{
    [CreateAssetMenu(fileName = "GameEvent", menuName = "Game Event", order = 52)]
    public class GameEventPublisher : ScriptableObject
    {
        private List<GameEventListener> listeners = new List<GameEventListener>();

        public void Raise()
        {
            for(int i=listeners.Count-1; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(GameEventListener listener)
        {
            listeners.Add(listener);
        }

        public void UnRegisterListener(GameEventListener listener)
        {
            listeners.Remove(listener);
        }
    }
}
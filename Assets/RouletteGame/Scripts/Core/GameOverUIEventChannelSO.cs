using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RouletteGame.Core
{
    [CreateAssetMenu(fileName = "GameOverUIEventChannelSO", menuName = "Event Channels/Game-over UI ")]
    public class GameOverUIEventChannelSO : ScriptableObject
    {
        public UnityEvent OnGiveUpClicked;
        public UnityEvent OnReviveWithAdsClicked;
        public UnityEvent OnReviveWithGoldClicked;

        public void RaiseOnGiveUpClicked()
        {
            OnGiveUpClicked?.Invoke();
        }

        public void RaiseOnReviceWithAdsClicked()
        {
            OnReviveWithAdsClicked?.Invoke();
        }

        public void RaiseOnReviveWithGoldClicked()
        {
            OnReviveWithGoldClicked?.Invoke();
        }
    }
}
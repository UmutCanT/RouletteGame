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

        /// <summary>
        /// 1.bool = isRevived
        /// 2.int = remainingChance
        /// 3.bool = reviveWithGold
        /// </summary>
        public UnityEvent<(bool, int, bool)> OnGameOverRespond;

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

        public void RaiseOnGameOverRespond(bool isRevived, int remainingChance, bool withGold)
        {
            OnGameOverRespond?.Invoke((isRevived, remainingChance, withGold));
        }
    }
}
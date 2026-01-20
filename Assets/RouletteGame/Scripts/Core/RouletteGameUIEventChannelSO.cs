using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RouletteGame.Core
{
    [CreateAssetMenu(fileName = "RouletteGameUIEventChannelSO", menuName = "Event Channel/Roulette Game UI ")]
    public class RouletteGameUIEventChannelSO : ScriptableObject
    {
        public UnityEvent<int> OnRewardLevelReceived;

        public UnityEvent OnSpinClicked;
        public UnityEvent<RewardData> OnRewardGranted;
        public UnityEvent OnRewardSequenceFinish;

        public void RaiseOnRewardLevelReceived(int rewardLevel)
        {
            OnRewardLevelReceived?.Invoke(rewardLevel);
        }

        public void RaiseOnSpinClicked()
        {
            OnSpinClicked?.Invoke();
        }

        public void RaiseOnRewardGranted(RewardData rewardData)
        {
            OnRewardGranted?.Invoke(rewardData);
        }

        public void RaiseOnRewardSequenceFinish()
        {
            OnRewardSequenceFinish?.Invoke();
        }
    }
}
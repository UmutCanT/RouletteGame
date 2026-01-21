using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RouletteGame.Core
{
    [CreateAssetMenu(fileName = "RouletteGameUIEventChannelSO", menuName = "Event Channels/Roulette Game UI ")]
    public class RouletteGameUIEventChannelSO : ScriptableObject
    {
        public UnityEvent<int> OnRewardLevelReceived;
        public UnityEvent OnSpinClicked;
        public UnityEvent<RewardData> OnRewardGranted;
        public UnityEvent OnRewardSequenceFinish;
        public UnityEvent<RewardData> OnGameOver;
        public UnityEvent<RewardData> OnUpdateRewardAmount;
        public UnityEvent<bool> OnQuit;

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

        public void RaiseOnGameOver(RewardData rewardData)
        {
            OnGameOver?.Invoke(rewardData);
        }

        public void RaiseOnUpdateRewardAmount(RewardData rewardData)
        {
            OnUpdateRewardAmount?.Invoke(rewardData);
        }

        public void RaiseOnQuit(bool quitPunishment) 
        {
            OnQuit?.Invoke(quitPunishment);
        }
    }
}
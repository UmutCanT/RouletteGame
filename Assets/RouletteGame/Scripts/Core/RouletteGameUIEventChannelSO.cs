using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RouletteGame.Core
{
    [CreateAssetMenu(fileName = "RouletteGameUIEventChannelSO", menuName = "Event Channel/Roulette Game UI ")]
    public class RouletteGameUIEventChannelSO : ScriptableObject
    {
        public UnityEvent OnSpinClicked;
        public UnityEvent OnStartSpin;
        public UnityEvent<RewardData> OnRewardGranted;
        public UnityEvent OnSpinFinished;

        public void RaiseOnSpinClicked()
        {

        }

        public void RaiseOnStartSpin()
        {

        }

        public void RaiseOnRewardGranted(RewardData rewardData)
        {
            OnRewardGranted?.Invoke(rewardData);
        }

        public void RaiseOnSpinFinished()
        {

        }
    }
}
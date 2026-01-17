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
        public UnityEvent<string> OnRewardGranted;
        public UnityEvent OnSpinFinished;

        public void RaiseOnSpinClicked()
        {

        }

        public void RaiseOnStartSpin()
        {

        }

        public void RaiseOnRewardGranted()
        {

        }

        public void RaiseOnSpinFinished()
        {

        }
    }
}
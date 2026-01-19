using RouletteGame.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class RouletteGameUIManager : MonoBehaviour
    {
        [SerializeField] private RouletteGameUIEventChannelSO rouletteGameUIEventChannel;
        [SerializeField] private Button rouletteSpinButton;
        [SerializeField] private RewardProgressUI rewardProgressUI;
        
        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }
    }
}
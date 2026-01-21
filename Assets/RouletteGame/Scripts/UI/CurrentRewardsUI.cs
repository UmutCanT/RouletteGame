using RouletteGame.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RouletteGame.UI
{
    public class CurrentRewardsUI : MonoBehaviour
    {
        [SerializeField] private List<CurrentRewardElementUI> currentRewardElementUIs;

        public void UpdateRewardEntery(RewardType rewardType)
        {
            foreach (var rewardElement in currentRewardElementUIs)
            {
                if(rewardElement.RewardType == rewardType)
                {
                    if (!rewardElement.isActiveAndEnabled)
                    {
                        rewardElement.gameObject.SetActive(true);
                    }
                }
                    
            }
        }
    }
}
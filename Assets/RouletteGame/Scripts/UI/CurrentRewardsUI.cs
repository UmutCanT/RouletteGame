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

        public void ChackRewardElementUIActivation(RewardType rewardType)
        {
            foreach (var rewardElement in currentRewardElementUIs)
            {
                if(rewardElement.RewardType == rewardType)
                {
                    if (!rewardElement.gameObject.activeSelf)
                    {
                        rewardElement.gameObject.SetActive(true);
                    }
                }
            }
        }

        public void UpdateRewardElementUI(RewardType rewardType, int amount)
        {
            foreach (var rewardElement in currentRewardElementUIs)
            {
                if (rewardElement.RewardType == rewardType)
                {
                    rewardElement.UpdateRewardElementText(amount);
                }
            }
        }
    }
}
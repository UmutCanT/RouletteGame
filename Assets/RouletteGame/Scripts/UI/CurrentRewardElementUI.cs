using RouletteGame.Core;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class CurrentRewardElementUI : MonoBehaviour
    {
        [SerializeField] private RewardType rewardType;
        [SerializeField] private TextMeshProUGUI rewardElementAmountText;

        public RewardType RewardType => rewardType;

        public void UpdateRewardElementText(int newAmount)
        {
            rewardElementAmountText.text =$"x{newAmount}";
        }
    }
}
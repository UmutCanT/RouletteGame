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

        private int amount;
        public RewardType RewardType => rewardType;

        private void OnEnable()
        {
            amount = 0;
        }

        public void UpdateRewardElementText(int newAmount)
        {
            amount += newAmount;
            Debug.LogWarning(amount);
            rewardElementAmountText.text = amount.ToString();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class CurrentRewardElementUI : MonoBehaviour
    {
        [SerializeField] private string rewardType;
        [SerializeField] private Image rewardElementIcon;
        [SerializeField] private TextMeshProUGUI rewardElementAmountText;

        public void UpdateRewardElementText(int newAmount)
        {
            rewardElementAmountText.text =$"x{newAmount}";
        }
    }
}
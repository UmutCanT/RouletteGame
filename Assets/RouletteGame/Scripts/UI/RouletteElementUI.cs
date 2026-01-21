using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class RouletteElementUI : MonoBehaviour
    {
        [SerializeField] private Image rewardIcon;
        [SerializeField] private TextMeshProUGUI rewardAmountText;

        public void UpdateRouletteElementUI(Sprite rewardIconSprite, int rewardAmount)
        {
            rewardIcon.sprite = rewardIconSprite;
            rewardAmountText.gameObject.SetActive(false);
            if (rewardAmount > 1)
            {
                rewardAmountText.gameObject.SetActive(true);
                rewardAmountText.text = $"x{rewardAmount}";
            }
        }       
    }
}
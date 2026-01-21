using RouletteGame.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace RouletteGame.UI
{
    public class RewardLevelItemUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI levelText;

        private Color originalColor;

        private void OnEnable()
        {
            originalColor = levelText.color;
        }

        public void UpdateLevelTextColor(Color textColor)
        {
            levelText.color = textColor;
        }


        public void BackToOriginalColor()
        {
            UpdateLevelTextColor(originalColor);
        }
    }
}
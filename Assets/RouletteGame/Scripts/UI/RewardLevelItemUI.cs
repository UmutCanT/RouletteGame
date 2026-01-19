using RouletteGame.Core;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace RouletteGame.UI
{
    public class RewardLevelItemUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI levelText;

        public void UpdateLevelText(int level, bool isCurrent, RouletteType rouletteType)
        {
            levelText.text = level.ToString();
            levelText.color = rouletteType == RouletteType.Bronze ? Color.black : Color.white;
            levelText.alpha = isCurrent ? 1 : 0.7f;
            transform.localScale = isCurrent ? Vector3.one * 1.2f : Vector3.one;
        }

        public void UpdateLevelText(int level)
        {
            levelText.text = level.ToString();
        }
    }
}
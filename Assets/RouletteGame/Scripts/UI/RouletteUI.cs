using RouletteGame.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class RouletteUI : MonoBehaviour
    {
        [SerializeField] private Image rouletteSpinWheel;
        [SerializeField] private Image rouletteIndicator;

        [SerializeField] private List<RouletteElementUI> rouletteElementUIs;

        public void UpdateRouletteWheel(RouletteDataSO rouletteDataSO)
        {
            rouletteSpinWheel.sprite = rouletteDataSO.RouletteSprite;
            rouletteIndicator.sprite = rouletteDataSO.RouletteIndicator;

            for (int i = 0; i < rouletteElementUIs.Count; i++)
            {
                RouletteElementUI rouletteElement = rouletteElementUIs[i];
                RouletteElementDataSO elementData = rouletteDataSO.RouletteElement[i];
                rouletteElement.UpdateRouletteElementUI(elementData.RewardIcon, elementData.RewardAmount);
            }
        }
    }
}
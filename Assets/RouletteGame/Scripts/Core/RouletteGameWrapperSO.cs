using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RouletteGame.Core
{
    [CreateAssetMenu(fileName = "RouletteGameWrapperSO", menuName = "Roulette/Roullete Game Spin Wrapper")]
    public class RouletteGameWrapperSO : ScriptableObject
    {
        [SerializeField] private RouletteDataSO[] rouletteData;
        [Header("Progress Text Colors")]
        [SerializeField] private Color bronzeAreaTextColor;
        [SerializeField] private Color silverAreaTextColor;
        [SerializeField] private Color goldAreaTextColor;
        [Header("Progress Area Image BG Color")]
        [SerializeField] private Color bronzeAreaBGColor;
        [SerializeField] private Color silverAreaBGColor;
        [SerializeField] private Color goldAreaBGColor;

        public RouletteDataSO[] RouletteData => rouletteData;

        public Color GetTextColor(int rewardLevel)
        {
            RouletteType rouletteType =rouletteData[rewardLevel - 1].RouletteType;

            if(rouletteType == RouletteType.Bronze)
                return bronzeAreaTextColor;

            if (rouletteType == RouletteType.Silver)
                return silverAreaTextColor;

            if (rouletteType == RouletteType.Gold)
                return goldAreaTextColor;

            return bronzeAreaTextColor;
        }

        public Color GetBGColor(int rewardLevel)
        {
            RouletteType rouletteType = rouletteData[rewardLevel - 1].RouletteType;

            if (rouletteType == RouletteType.Bronze)
                return bronzeAreaBGColor;

            if (rouletteType == RouletteType.Silver)
                return silverAreaBGColor;

            if (rouletteType == RouletteType.Gold)
                return goldAreaBGColor;

            return bronzeAreaBGColor;
        }
    }
}
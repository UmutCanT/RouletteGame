using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RouletteGame.Core
{
    [CreateAssetMenu(fileName = "RouletteRewardElementSO", menuName = "Roulette/Reward Element")]
    public class RouletteElementDataSO : ScriptableObject
    {
        [SerializeField] private RewardData rewardData;
        [SerializeField] private string rewardName;
        [SerializeField] private Sprite rewardIcon;
    }
}
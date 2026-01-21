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

        public string RewardName => rewardName;
        public Sprite RewardIcon => rewardIcon;
        public int RewardAmount => rewardData.Amount;
        public string RewardId => rewardData.RewardId;
        public RewardType RewardType => rewardData.RewardType;
    }
}
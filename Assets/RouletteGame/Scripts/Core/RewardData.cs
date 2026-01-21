using System;

namespace RouletteGame.Core
{
    [Serializable]
    public class RewardData
    {
        public string RewardId;
        public RewardType RewardType;
        public int Amount;
    }
}
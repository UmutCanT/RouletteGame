using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace RouletteGame.Core
{
    public interface IRewardService
    {
        public Task<SpinResult> SpinRequest();
        public Task<int> RewardLevelRequest();
        public Task<int> RewardMaxLevelRequest();
        public Task<(bool, int)> ReviveWithGoldRequest();
        public Task<(bool, int)> ReviveWithAdsRequest();
        public Task GiveUpRequest();
    }
}
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace RouletteGame.Core
{
    public interface IRewardService
    {
        public Task<SpinResult> SpinRequest(string playerId);
        public Task<int> RewardLevelRequest(string playerId);

    }
}
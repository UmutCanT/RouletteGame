using RouletteGame.Core;
using RouletteGame.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Random = System.Random;

namespace Test
{
    public class MockRewardService : IRewardService
    {
        public class MockPlayerData
        {
            public string playerId;
            public int rewardLevel;
            public int reviveWithGoldChance;
            public int reviveWithAdsChance;
            public bool isRevived;

            public MockPlayerData(string playerId, int rewardLevel, int reviveWithGoldChance, int reviveWithAdsChance)
            {
                this.playerId = playerId;
                this.rewardLevel = rewardLevel;
                this.reviveWithGoldChance = reviveWithGoldChance;
                this.reviveWithAdsChance = reviveWithAdsChance;
                isRevived = false;
            }
        }

        private MockPlayerData playerData;
        private readonly Random random;

        public MockRewardService(string playerId)
        {
            playerData = new MockPlayerData(playerId, 1, 3, 1);
            random = new Random();
        }

        public Task<int> RewardLevelRequest()
        {
            return Task.FromResult(playerData.rewardLevel);
        }

        public Task<SpinResult> SpinRequest()
        {
            var currentRewardRoulette = MockRouletteData.Wheels[playerData.rewardLevel];

            RouletteElement pickedRouletteELement;

            if(playerData.isRevived)
                pickedRouletteELement = PickWeighted(currentRewardRoulette.Elements);
            else
                pickedRouletteELement = PickWeighted(currentRewardRoulette.Elements);

            bool isGameOver = pickedRouletteELement.Type == RouletteElementType.GameOver;
            if (!isGameOver)
                UpdateRewardLevel(playerData.rewardLevel);

            return Task.FromResult(new SpinResult
            {
                rewardData = pickedRouletteELement.Reward,
                isGameOver = isGameOver
            });
        }

        private RouletteElement PickWeighted(List<RouletteElement> elements)
        {
            int totalWeight = 0;
            foreach (var e in elements)
                totalWeight += e.Weight;

            int roll = random.Next(0, totalWeight);
            int current = 0;

            foreach (var e in elements)
            {
                current += e.Weight;
                if (roll < current)
                    return e;
            }

            return elements[0];
        }

        private void UpdateRewardLevel(int rewardLevel)
        {
            playerData.rewardLevel = rewardLevel + 1;
        }

        public Task<int> RewardMaxLevelRequest()
        {
            return Task.FromResult(MockRouletteData.Wheels.Count);
        }

        public Task<bool> ReviveWithGoldRequest()
        {
            if(playerData.reviveWithGoldChance > 0)
            {
                playerData.reviveWithGoldChance--;
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task<bool> ReviveWithAdsRequest()
        {
            if (playerData.reviveWithAdsChance > 0)
            {
                playerData.reviveWithAdsChance--;
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task GiveUpRequest()
        {
            string playerId = playerData.playerId;
            playerData = new MockPlayerData(playerId, 1, 3, 1);

            return Task.CompletedTask;
        }
    }
}
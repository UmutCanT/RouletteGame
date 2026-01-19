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

            public MockPlayerData(string playerId, int rewardLevel)
            {
                this.playerId = playerId;
                this.rewardLevel = rewardLevel;
            }
        }

        private MockPlayerData playerData;
        private readonly Random random;

        public MockRewardService(string playerId)
        {
            if(!PlayerPrefs.HasKey(playerId))
                PlayerPrefs.SetInt(playerId, 1);

            playerData = new MockPlayerData(playerId, PlayerPrefs.GetInt(playerId, 1));
            random = new Random();
        }

        public Task<int> RewardLevelRequest()
        {
            return Task.FromResult(playerData.rewardLevel);
        }

        public Task<SpinResult> SpinRequest()
        {
            var currentRewardRoulette = MockRouletteData.Wheels[playerData.rewardLevel];

            var pickedRouletteELement = PickWeighted(currentRewardRoulette.Elements);

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
            playerData.rewardLevel = rewardLevel;

            PlayerPrefs.SetInt(playerData.playerId, rewardLevel);
            PlayerPrefs.Save();
        }

        public Task<int> RewardMaxLevelRequest()
        {
            return Task.FromResult(MockRouletteData.Wheels.Count);
        }
    }
}
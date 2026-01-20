using RouletteGame.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public static class MockRouletteData
    {
        public static List<RouletteWheelConfig> Wheels = new()
        {
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 1,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                    //new RouletteElement
                    //{                   
                    //    Type = RouletteElementType.GameOver,
                    //    Weight = 10
                    //}
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 1,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 1,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 1,
                Elements = new List<RouletteElement>
                {
                   new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "coin", Amount = 100 },
                        Weight = 40
                    },
                }
            },
        };
    }
}
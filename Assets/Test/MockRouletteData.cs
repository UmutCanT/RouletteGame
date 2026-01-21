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
                Type = RouletteType.Silver,
                RewardLevel = 1,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0002", Amount = 10000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0013", Amount = 5 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0009", Amount = 1 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0014", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0018", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0021", Amount = 5 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0026", Amount = 1 },
                        Weight = 20
                    },                    
                }
            },           
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 2,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0001", Amount = 3000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0007", Amount = 1 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0017", Amount = 5 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 10
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0009", Amount = 1 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0008", Amount = 1 },
                        Weight = 20
                    },                    
                }
            },           
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 3,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0001", Amount = 3000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0007", Amount = 1 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0017", Amount = 5 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 10
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0009", Amount = 1 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0008", Amount = 1 },
                        Weight = 20
                    },                    
                }
            },           
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 4,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0001", Amount = 3000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0007", Amount = 1 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0017", Amount = 5 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 10
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0009", Amount = 1 },
                        Weight = 20
                    },                    
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0008", Amount = 1 },
                        Weight = 20
                    },                    
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Silver,
                RewardLevel = 5,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0002", Amount = 10000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0013", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0009", Amount = 1 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0014", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0018", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0021", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0026", Amount = 1 },
                        Weight = 20
                    },
                }
            },
        };
    }
}
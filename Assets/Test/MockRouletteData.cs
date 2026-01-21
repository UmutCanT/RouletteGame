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
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 6,
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
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
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
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0020", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0010", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 7,
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
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
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
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0020", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0010", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 8,
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
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
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
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0020", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0010", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 9,
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
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
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
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0020", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0010", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Silver,
                RewardLevel = 10,
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
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
                        Reward = new RewardData { RewardId = "0003", Amount = 25000 },
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
                        Reward = new RewardData { RewardId = "0019", Amount = 5 },
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
                        Reward = new RewardData { RewardId = "0026", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 11,
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
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
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
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 60
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0020", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0010", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 12,
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
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
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
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 60
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0020", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0010", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 13,
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
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
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
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 60
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0020", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0010", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 14,
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
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
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
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 60
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0020", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0010", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Silver,
                RewardLevel = 15,
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
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
                        Reward = new RewardData { RewardId = "0003", Amount = 25000 },
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
                        Reward = new RewardData { RewardId = "0019", Amount = 5 },
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
                        Reward = new RewardData { RewardId = "0026", Amount = 1 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 16,
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
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0002", Amount = 10000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 100
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0012", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0013", Amount = 5 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 17,
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
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0002", Amount = 10000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 100
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0012", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0013", Amount = 5 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 18,
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
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0002", Amount = 10000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 100
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0012", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0013", Amount = 5 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 19,
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
                        Reward = new RewardData { RewardId = "0011", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0002", Amount = 10000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 100
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0004", Amount = 5 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0012", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0013", Amount = 5 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Silver,
                RewardLevel = 20,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0003", Amount = 25000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0006", Amount = 50 },
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
                        Reward = new RewardData { RewardId = "0021", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0015", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0025", Amount = 1 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0002", Amount = 10000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 21,
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 130
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0012", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0003", Amount = 25000 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 22,
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 130
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0012", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0003", Amount = 25000 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 23,
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 130
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0012", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0003", Amount = 25000 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Bronze,
                RewardLevel = 24,
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
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
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.GameOver,
                        Reward = new RewardData { RewardId = "0000", Amount = 1 },
                        Weight = 130
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0023", Amount = 5 },
                        Weight = 30
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0012", Amount = 10 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0003", Amount = 25000 },
                        Weight = 20
                    },
                }
            },
            new RouletteWheelConfig
            {
                Type = RouletteType.Silver,
                RewardLevel = 25,
                Elements = new List<RouletteElement>
                {
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0003", Amount = 25000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0006", Amount = 50 },
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
                        Reward = new RewardData { RewardId = "0021", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0015", Amount = 5 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0025", Amount = 1 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0002", Amount = 10000 },
                        Weight = 20
                    },
                    new RouletteElement
                    {
                        Type = RouletteElementType.Reward,
                        Reward = new RewardData { RewardId = "0005", Amount = 10 },
                        Weight = 20
                    },
                }
            },
        };
    }
}
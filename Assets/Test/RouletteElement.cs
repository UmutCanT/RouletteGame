using RouletteGame.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public class RouletteElement
    {
        public RouletteElementType Type;
        public RewardData Reward; 
        public int Weight;
    }

    public enum RouletteElementType
    {
        Reward,
        GameOver
    }
}
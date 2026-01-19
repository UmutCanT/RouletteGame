using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RouletteGame.Core
{
    [Serializable]
    public class SpinResult : MonoBehaviour
    {
        public RewardData rewardData;
        public bool isGameOver;
    }
}
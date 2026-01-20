using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RouletteGame.Core
{
    [CreateAssetMenu(fileName = "RouletteGameWrapperSO", menuName = "Roulette/Roullete Game Spin Wrapper")]
    public class RouletteGameWrapperSO : ScriptableObject
    {
        [SerializeField] private RouletteDataSO[] rouletteData;

        public RouletteDataSO[] RouletteData => rouletteData;
    }
}
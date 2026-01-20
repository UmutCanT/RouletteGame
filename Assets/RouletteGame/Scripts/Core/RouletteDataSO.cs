using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RouletteGame.Core
{
    [CreateAssetMenu(fileName = "RouletteDataSO", menuName = "Roulette/Roulette Spin")]
    public class RouletteDataSO : ScriptableObject
    {
        [SerializeField] private Sprite rouletteSprite;
        [SerializeField] private Sprite rouletteIndicator;
        [SerializeField] private RouletteType rouletteType;
        [SerializeField] private RouletteElementDataSO[] rouletteElement;

        public Sprite RouletteSprite => rouletteSprite;
        public Sprite RouletteIndicator => rouletteIndicator; 
        public RouletteType RouletteType => rouletteType; 
        public RouletteElementDataSO[] RouletteElement => rouletteElement; 
    }
}
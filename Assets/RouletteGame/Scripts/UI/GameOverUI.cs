using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class GameOverUI : MonoBehaviour
    {
        [SerializeField] private Button giveUpButton;
        [SerializeField] private Button reviveWithGoldButton;
        [SerializeField] private Button reviveWithAdsButton;

        [SerializeField] private Image glowImage;
        [SerializeField] private Image flashImage;
        [SerializeField] private Image shineImage;
    }
}
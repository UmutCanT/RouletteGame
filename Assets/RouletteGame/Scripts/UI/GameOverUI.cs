using RouletteGame.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class GameOverUI : MonoBehaviour
    {
        [SerializeField] private GameOverUIEventChannelSO gameOverUIEventChannel;

        [SerializeField] private Button giveUpButton;
        [SerializeField] private Button reviveWithGoldButton;
        [SerializeField] private Button reviveWithAdsButton;

        [SerializeField] private Image glowImage;
        [SerializeField] private Image flashImage;
        [SerializeField] private Image shineImage;

        private void OnEnable()
        {
            giveUpButton.onClick.AddListener(gameOverUIEventChannel.RaiseOnGiveUpClicked);
            reviveWithGoldButton.onClick.AddListener(gameOverUIEventChannel.RaiseOnReviveWithGoldClicked);
            reviveWithAdsButton.onClick.AddListener(gameOverUIEventChannel.RaiseOnReviceWithAdsClicked);
        }

        private void OnDisable()
        {
            giveUpButton.onClick.RemoveListener(gameOverUIEventChannel.RaiseOnGiveUpClicked);
            reviveWithGoldButton.onClick.RemoveListener(gameOverUIEventChannel.RaiseOnReviveWithGoldClicked);
            reviveWithAdsButton.onClick.RemoveListener(gameOverUIEventChannel.RaiseOnReviceWithAdsClicked);
        }
    }
}
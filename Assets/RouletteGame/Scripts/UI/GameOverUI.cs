using RouletteGame.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
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

        [SerializeField] private TextMeshProUGUI reviveWithGoldButtonText;
        [SerializeField] private TextMeshProUGUI reviveWithAdsButtonText;

        [SerializeField] private Image glowImage;
        [SerializeField] private Image flashImage;
        [SerializeField] private Image shineImage;

        private void OnEnable()
        {
            gameOverUIEventChannel.OnGameOverRespond.AddListener(OnGameOverRespond);
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

        /// <summary>
        /// 1.bool = isRevived
        /// 2.int = remainingChance
        /// 3.bool = reviveWithGold
        /// </summary>
        private void OnGameOverRespond((bool, int, bool) respond)
        {
            if (respond.Item3)
            {
                reviveWithGoldButtonText.text = $"Canlan: {respond.Item2}";
            }
            else
            {
                reviveWithAdsButtonText.text = $"Canlan: {respond.Item2}";
            }


            if (respond.Item1)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
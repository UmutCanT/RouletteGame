using RouletteGame.Core;
using RouletteGame.Manager;
using RouletteGame.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    /// <summary>
    /// Module test boot
    /// </summary>
    public class BootHandler : MonoBehaviour
    {
        private static string TEST_PLAYER_ID = "player123";
        private RouletteGameManager gameManager;     

        private void Awake()
        {
            ServiceLocator.Register<IRewardService>(new MockRewardService(TEST_PLAYER_ID));
            gameManager = FindAnyObjectByType<RouletteGameManager>().GetComponent<RouletteGameManager>(); // Normally instantiate from prefab
        }

        void Start()
        {
            gameManager.Initialize();
        }

        public void PlayerClaimedAllRewards()
        {
            FindAnyObjectByType<QuitWarningUI>().GetComponent<QuitWarningUI>().ShowWithOnlyQuitOption();
            FindAnyObjectByType<RouletteGameUIManager>().GetComponent<RouletteGameUIManager>().HideQuitButton();
        }
    }
}
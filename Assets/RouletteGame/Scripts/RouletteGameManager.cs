using RouletteGame.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Test;
using UnityEngine;

namespace RouletteGame.Manager
{
    public class RouletteGameManager : MonoBehaviour
    {
        //eventChannels
        [SerializeField] private RouletteGameUIEventChannelSO rouletteGameUIEventChannel;
        [SerializeField] private GameOverUIEventChannelSO gameOverUIEventChannel;

        private IRewardService rewardService;      
        private RewardData lastRewardData;
        private bool quitPunishment;
        private int maxLevel = 0;
       
        public void Initialize()
        {
            rewardService = ServiceLocator.Resolve<IRewardService>();
            rouletteGameUIEventChannel.OnSpinClicked.AddListener(OnSpinClicked);
            rouletteGameUIEventChannel.OnRewardSequenceFinish.AddListener(OnRewardSequenceFinished);
            rouletteGameUIEventChannel.OnQuitClicked.AddListener(ActivateQuitWarning);
            gameOverUIEventChannel.OnReviveWithAdsClicked.AddListener(OnReviveWithAdsClicked);
            gameOverUIEventChannel.OnReviveWithGoldClicked.AddListener(OnReviveWithGoldClicked);
            gameOverUIEventChannel.OnGiveUpClicked.AddListener(ActivateQuitWarning);
            lastRewardData = new RewardData();
            quitPunishment = true;
            GetMaxRewardLevel();
            UpdateNextRewardLevel();
        }
     
        private void OnDisable()
        {
            rouletteGameUIEventChannel.OnSpinClicked.RemoveListener(OnSpinClicked);
            rouletteGameUIEventChannel.OnRewardSequenceFinish.RemoveListener(OnRewardSequenceFinished);
            rouletteGameUIEventChannel.OnQuitClicked.RemoveListener(ActivateQuitWarning);
            gameOverUIEventChannel.OnReviveWithAdsClicked.RemoveListener(OnReviveWithAdsClicked);
            gameOverUIEventChannel.OnReviveWithGoldClicked.RemoveListener(OnReviveWithGoldClicked);
            gameOverUIEventChannel.OnGiveUpClicked.RemoveListener(ActivateQuitWarning);
        }

        public async void OnSpinClicked()
        {
            Debug.LogWarning("Spin Req Start");
            try
            {                
                Task<SpinResult> spinTask = rewardService.SpinRequest();
                SpinResult response = await spinTask;

                if (response.isGameOver)
                {
                    rouletteGameUIEventChannel.RaiseOnGameOver(response.rewardData);
                }
                else
                {
                    rouletteGameUIEventChannel.RaiseOnRewardGranted(response.rewardData);
                    lastRewardData.RewardId = response.rewardData.RewardId;
                    lastRewardData.Amount = response.rewardData.Amount;
                    Debug.LogWarning("LastRewardData " +  lastRewardData.RewardId);
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Spin failed: {e}");
            }
        }

        private async void OnReviveWithGoldClicked()
        {
            try
            {
                Task<(bool, int)> reviveTask = rewardService.ReviveWithGoldRequest();
                (bool, int) response = await reviveTask;

                if (response.Item1)
                {
                    gameOverUIEventChannel.RaiseOnGameOverRespond(true, response.Item2, true);
                    UpdateNextRewardLevel();
                }
                else
                {
                    gameOverUIEventChannel.RaiseOnGameOverRespond(false, response.Item2, true);
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"OnReviveWithGoldClicked failed: {e}");
            }          
        }

        private async void OnReviveWithAdsClicked()
        {
            try
            {
                Task<(bool, int)> reviveTask = rewardService.ReviveWithAdsRequest();
                (bool, int) response = await reviveTask;

                if (response.Item1)
                {
                    gameOverUIEventChannel.RaiseOnGameOverRespond(true, response.Item2, false);
                    UpdateNextRewardLevel();
                }
                else
                {
                    gameOverUIEventChannel.RaiseOnGameOverRespond(false, response.Item2, false);
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"OnReviveWithAdsClicked failed: {e}");
            }

        }    

        private async void UpdateNextRewardLevel()
        {            
            try
            {
                Task<int> rewardLevelTask = rewardService.RewardLevelRequest();
                int rewardLevel = await rewardLevelTask;

                Task<bool> quitPunishmentCheckTask = rewardService.CheckQuitPunishmentStatusRequest();
                quitPunishment = await quitPunishmentCheckTask;

                if(rewardLevel <= maxLevel)
                {
                    Debug.LogWarning("Next Reward Req Start " + rewardLevel + " quit punishment " + quitPunishment);
                    rouletteGameUIEventChannel.RaiseOnRewardLevelReceived(rewardLevel);
                }
                else
                {
                    FindAnyObjectByType<BootHandler>().GetComponent<BootHandler>().PlayerClaimedAllRewards();
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Reward Level Request Failed: {e}");
            }
        } 

        private async void GetMaxRewardLevel()
        {            
            try
            {
                Task<int> rewardLevelTask = rewardService.RewardMaxLevelRequest();
                maxLevel = await rewardLevelTask;
            }
            catch (Exception e)
            {
                Debug.LogError($"Reward Level Request Failed: {e}");
            }
        } 
        
        private void OnRewardSequenceFinished()
        {
            Debug.Log(lastRewardData.Amount + " here");
            rouletteGameUIEventChannel.RaiseOnUpdateRewardAmount(lastRewardData);
            UpdateNextRewardLevel();
        }

        private void ActivateQuitWarning(bool punishment)
        {
            if (punishment)
                rouletteGameUIEventChannel.RaiseOnQuitWarningActivated(true);
            else
                rouletteGameUIEventChannel.RaiseOnQuitWarningActivated(quitPunishment);
        }
    }
}
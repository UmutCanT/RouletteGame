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
       
        public void Initialize()
        {
            rewardService = ServiceLocator.Resolve<IRewardService>();
            rouletteGameUIEventChannel.OnSpinClicked.AddListener(OnSpinClicked);
            rouletteGameUIEventChannel.OnRewardSequenceFinish.AddListener(OnRewardSequenceFinished);
            gameOverUIEventChannel.OnReviveWithAdsClicked.AddListener(OnReviveWithAdsClicked);
            gameOverUIEventChannel.OnReviveWithGoldClicked.AddListener(OnReviveWithGoldClicked);
            lastRewardData = new RewardData();
            quitPunishment = true;
            UpdateNextRewardLevel();
        }

        private void OnDisable()
        {
            rouletteGameUIEventChannel.OnSpinClicked.RemoveListener(OnSpinClicked);
            rouletteGameUIEventChannel.OnRewardSequenceFinish.RemoveListener(OnRewardSequenceFinished);
            gameOverUIEventChannel.OnReviveWithAdsClicked.RemoveListener(OnReviveWithAdsClicked);
            gameOverUIEventChannel.OnReviveWithGoldClicked.RemoveListener(OnReviveWithGoldClicked);
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
                Debug.LogWarning("Next Reward Req Start " + rewardLevel + " quit punishment " + quitPunishment);
                rouletteGameUIEventChannel.RaiseOnRewardLevelReceived(rewardLevel);
            }
            catch (Exception e)
            {
                Debug.LogError($"Reward Level Request Failed: {e}");
            }
            finally
            {
                Debug.LogWarning("Next Reward Req Finish");
            }
        } 
        
        private void OnRewardSequenceFinished()
        {
            Debug.Log(lastRewardData.Amount + " here");
            rouletteGameUIEventChannel.RaiseOnUpdateRewardAmount(lastRewardData);
            UpdateNextRewardLevel();
        }
    }
}
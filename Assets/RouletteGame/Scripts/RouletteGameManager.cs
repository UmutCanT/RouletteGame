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
        private CancellationTokenSource cancellationTokenSource;

        private void OnDisable()
        {
            rouletteGameUIEventChannel.OnSpinClicked.RemoveListener(OnSpinClicked);
            rouletteGameUIEventChannel.OnRewardSequenceFinish.RemoveListener(UpdateNextRewardLevel);
            gameOverUIEventChannel.OnGiveUpClicked.RemoveListener(OnGiveUpClicked);
            gameOverUIEventChannel.OnReviveWithAdsClicked.RemoveListener(OnReviveWithAdsClicked);
            gameOverUIEventChannel.OnReviveWithGoldClicked.RemoveListener(OnReviveWithGoldClicked);

            cancellationTokenSource?.Cancel();
            cancellationTokenSource?.Dispose();
        }

        public void Initialize()
        {
            rewardService = ServiceLocator.Resolve<IRewardService>();
            rouletteGameUIEventChannel.OnSpinClicked.AddListener(OnSpinClicked);
            rouletteGameUIEventChannel.OnRewardSequenceFinish.AddListener(UpdateNextRewardLevel);
            gameOverUIEventChannel.OnGiveUpClicked.AddListener(OnGiveUpClicked);
            gameOverUIEventChannel.OnReviveWithAdsClicked.AddListener(OnReviveWithAdsClicked);
            gameOverUIEventChannel.OnReviveWithGoldClicked.AddListener(OnReviveWithGoldClicked);

            UpdateNextRewardLevel();
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
                }else
                    rouletteGameUIEventChannel.RaiseOnRewardGranted(response.rewardData);
            }
            catch (Exception e)
            {
                Debug.LogError($"Spin failed: {e}");
            }
            finally
            {
                Debug.LogWarning("Spin Req Finish");
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
                    UpdateNextRewardLevel();
                }
                else
                {
                    //CantRevive
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Spin failed: {e}");
            }
            finally
            {
                Debug.LogWarning("Spin Req Finish");
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
                    UpdateNextRewardLevel();
                }
                else
                {
                    //CantRevive
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Spin failed: {e}");
            }
            finally
            {
                Debug.LogWarning("Spin Req Finish");
            }
        }

        private async void OnGiveUpClicked()
        {
            try
            {
                var reviveTask = rewardService.GiveUpRequest();
                await reviveTask;

                

                //BackToMainMenu
            }
            catch (Exception e)
            {
                Debug.LogError($"Spin failed: {e}");
            }
            finally
            {
                Debug.LogWarning("Spin Req Finish");
            }
        }

        private async void UpdateNextRewardLevel()
        {
            Debug.LogWarning("Next Reward Req Start");
            try
            {
                Task<int> rewardLevelTask = rewardService.RewardLevelRequest();
                int rewardLevel = await rewardLevelTask;
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
    }
}
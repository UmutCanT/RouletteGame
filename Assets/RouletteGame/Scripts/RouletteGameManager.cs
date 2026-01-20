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

        private IRewardService rewardService;
        private CancellationTokenSource cancellationTokenSource;

        public void Initialize()
        {
            rewardService = ServiceLocator.Resolve<IRewardService>();
            rouletteGameUIEventChannel.OnSpinClicked.AddListener(OnSpinClicked);
            rouletteGameUIEventChannel.OnRewardSequenceFinish.AddListener(UpdateNextRewardLevel);

            UpdateNextRewardLevel();
        }

        public async void OnSpinClicked()
        {
            Debug.LogWarning("Spin Req Start");
            try
            {                
                Task<SpinResult> spinTask = rewardService.SpinRequest();
                SpinResult response = await spinTask;
                if (response != null)
                {
                    Debug.Log(response.ToString());
                }
                else
                {
                    Debug.Log("response is null");
                }
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

        private void OnDisable()
        {
            rouletteGameUIEventChannel.OnSpinClicked.RemoveListener(OnSpinClicked);
            rouletteGameUIEventChannel.OnRewardSequenceFinish.RemoveListener(UpdateNextRewardLevel);
            cancellationTokenSource?.Cancel();
            cancellationTokenSource?.Dispose();
        }
    }
}
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
        [SerializeField] private RouletteGameWrapperSO rouletteGameWrapper;

        private IRewardService rewardService;
        private bool isRouletteSpinning;


        private CancellationTokenSource cancellationTokenSource;

        public async void Initialize(string playerID)
        {
            rewardService = ServiceLocator.Resolve<IRewardService>();
            rouletteGameUIEventChannel.OnSpinClicked.AddListener(OnSpinClicked);

            try
            {
                Task<int> rewardLevelTask = rewardService.RewardLevelRequest();
                int rewardLevel = await rewardLevelTask;
                rouletteGameUIEventChannel.RaiseOnRewardLevelReceived(rewardLevel);
            }
            catch (Exception e)
            {
                Debug.LogError($"Reward Level REquest Failed: {e}");
            }
        }

        public async void OnSpinClicked()
        {
            if (isRouletteSpinning)
                return;

            isRouletteSpinning = true;

            try
            {                
                Task<SpinResult> spinTask = rewardService.SpinRequest();
                SpinResult response = await spinTask;
                rouletteGameUIEventChannel.RaiseOnRewardGranted(response.rewardData);
            }
            catch (Exception e)
            {
                Debug.LogError($"Spin failed: {e}");
            }
            finally
            {
                isRouletteSpinning = false;
            }
        }

        private void OnDisable()
        {
            cancellationTokenSource?.Cancel();
            cancellationTokenSource?.Dispose();
        }
    }
}
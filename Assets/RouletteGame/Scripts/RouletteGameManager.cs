using RouletteGame.Core;
using System;
using System.Collections;
using System.Collections.Generic;
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
        private bool isRouletteSpinning;

        public void Initialize()
        {
            rewardService = ServiceLocator.Resolve<IRewardService>();
            rouletteGameUIEventChannel.OnSpinClicked.AddListener(OnSpinClicked);
        }

        public async void OnSpinClicked()
        {
            if (isRouletteSpinning)
                return;

            isRouletteSpinning = true;

            try
            {                
                Task<RewardData> spinTask = rewardService.SpinRequest("sadgsdg");
                RewardData response = await spinTask;
                rouletteGameUIEventChannel.RaiseOnRewardGranted(response);
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
    }
}
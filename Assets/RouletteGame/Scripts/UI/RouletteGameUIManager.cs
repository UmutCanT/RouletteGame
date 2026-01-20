using RouletteGame.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class RouletteGameUIManager : MonoBehaviour
    {
        [SerializeField] private RouletteGameWrapperSO rouletteGameWrapper;
        [SerializeField] private RouletteGameUIEventChannelSO rouletteGameUIEventChannel;
        [SerializeField] private Button rouletteSpinButton;
        [SerializeField] private RewardProgressUI rewardProgressUI;
        [SerializeField] private RouletteUI rouletteUI;
        
        private void OnEnable()
        {
            rouletteGameUIEventChannel.OnRewardLevelReceived.AddListener(RewardLevelChangedUIUpdate);
            rouletteGameUIEventChannel.OnRewardGranted.AddListener(RewardGrantedSequence);
            rouletteSpinButton.onClick.AddListener(OnSpinButtonClick);
        }

        private void OnDisable()
        {
            rouletteGameUIEventChannel.OnRewardLevelReceived.RemoveListener(RewardLevelChangedUIUpdate);
            rouletteGameUIEventChannel.OnRewardGranted.RemoveListener(RewardGrantedSequence);
            rouletteSpinButton.onClick.RemoveListener(OnSpinButtonClick);
        }

        private void RewardLevelChangedUIUpdate(int rewardLevel)
        {
            Debug.Log("Update Reward Level UI " + rewardLevel);
            rewardProgressUI.UpdateProgressBar(rewardLevel);
            rouletteUI.UpdateRouletteWheel(rouletteGameWrapper.RouletteData[rewardLevel]);
            rouletteSpinButton.interactable = true;
            Debug.Log("Update Reward Level UI " + rouletteSpinButton.interactable);

        }

        private async void RewardGrantedSequence(RewardData rewardData)
        {
            Debug.Log("RewardGrantedSequence UI " + rewardData.RewardId);
            try
            {
                await rouletteUI.StopRouletteWheelSpin(rewardData.RewardId);
                //Other sequences too
            }
            catch (Exception e)
            {
                Debug.LogError($"Reward sequence failed: {e.StackTrace}");
            }
            finally
            {
                rouletteGameUIEventChannel.RaiseOnRewardSequenceFinish();
            }           
        }

        private void OnSpinButtonClick()
        {
            rouletteSpinButton.interactable = false;
            rouletteUI.SpinRouletteWheel();
            rouletteGameUIEventChannel.RaiseOnSpinClicked();
            Debug.Log("OnSpinButtonClick " + rouletteSpinButton.interactable);
        }
    }
}
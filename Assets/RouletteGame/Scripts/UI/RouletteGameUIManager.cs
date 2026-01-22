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
        [SerializeField] private Button quitButton;
        [SerializeField] private RewardProgressUI rewardProgressUI;
        [SerializeField] private RouletteUI rouletteUI;
        [SerializeField] private CurrentRewardsUI currentRewardsUI;
        [SerializeField] private GameOverUI gameOverUI;
        [SerializeField] private AreaLevelIndicatorUI areaLevelIndicatorUI;
        [SerializeField] private QuitWarningUI quitWarningUI;

        private int currentRewardLevel;

        private void OnValidate()
        {
            if (rouletteSpinButton == null)
                rouletteSpinButton = GameObject.FindGameObjectWithTag("SpinButton").GetComponent<Button>();

            if (quitButton == null)
                quitButton = GameObject.FindGameObjectWithTag("QuitButton").GetComponent<Button>();
        }


        private void OnEnable()
        {
            rouletteGameUIEventChannel.OnRewardLevelReceived.AddListener(RewardLevelChangedUIUpdate);
            rouletteGameUIEventChannel.OnRewardGranted.AddListener(RewardGrantedSequence);
            rouletteGameUIEventChannel.OnGameOver.AddListener(GameOverSequence);
            rouletteGameUIEventChannel.OnUpdateRewardAmount.AddListener(UpdateCurrentRewardsUI);
            rouletteGameUIEventChannel.OnQuitWarningActivated.AddListener(OnQuitWarningActivated);
            rouletteSpinButton.onClick.AddListener(OnSpinButtonClick);
            quitButton.onClick.AddListener(rouletteGameUIEventChannel.RaiseOnQuit);
            gameOverUI.gameObject.SetActive(false);
        }
     
        private void OnDisable()
        {
            rouletteGameUIEventChannel.OnRewardLevelReceived.RemoveListener(RewardLevelChangedUIUpdate);
            rouletteGameUIEventChannel.OnRewardGranted.RemoveListener(RewardGrantedSequence);
            rouletteGameUIEventChannel.OnGameOver.RemoveListener(GameOverSequence);
            rouletteGameUIEventChannel.OnUpdateRewardAmount.RemoveListener(UpdateCurrentRewardsUI);
            rouletteGameUIEventChannel.OnQuitWarningActivated.RemoveListener(OnQuitWarningActivated);
            rouletteSpinButton.onClick.RemoveListener(OnSpinButtonClick);
            quitButton.onClick.RemoveListener(rouletteGameUIEventChannel.RaiseOnQuit);
        }

        private void RewardLevelChangedUIUpdate(int rewardLevel)
        {
            RouletteDataSO rouletteDataSO = rouletteGameWrapper.RouletteData[rewardLevel - 1];
            currentRewardLevel = rewardLevel;
            rewardProgressUI.UpdateProgressBar(rewardLevel, rouletteGameWrapper.GetTextColor(rewardLevel),
                rouletteGameWrapper.GetBGColor(rewardLevel));
            rouletteUI.UpdateRouletteWheel(rouletteDataSO);

            areaLevelIndicatorUI.UpdateSilverAreaIndicatorText(FindNextSilverAreaLevel(rewardLevel));
            areaLevelIndicatorUI.UpdateGoldAreaIndicatorText(FindNextGoldAreaLevel(rewardLevel));

            rouletteSpinButton.interactable = true;
            
            if (!quitButton.gameObject.activeSelf)
                quitButton.gameObject.SetActive(true);

            quitButton.interactable = true;
        }

        private void OnQuitWarningActivated(bool punishmentStatus)
        {
            quitWarningUI.ShowQuitWarningPopUp(punishmentStatus);
        }

        private async void GameOverSequence(RewardData rewardData)
        {
            Debug.Log("RewardGrantedSequence UI " + rewardData.RewardId);
            try
            {
                await rouletteUI.StopRouletteWheelSpin(FindRewardDataIndex(rewardData.RewardId));
                gameOverUI.gameObject.SetActive(true);
                HideQuitButton();
            }
            catch (Exception e)
            {
                Debug.LogError($"Game-Over sequence failed: {e.StackTrace}");
            }
        }

        private async void RewardGrantedSequence(RewardData rewardData)
        {
            Debug.Log("RewardGrantedSequence UI " + rewardData.RewardId);
            try
            {
                await rouletteUI.StopRouletteWheelSpin(FindRewardDataIndex(rewardData.RewardId));
                currentRewardsUI.ChackRewardElementUIActivation(FindRewardDataType(rewardData.RewardId));
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
            quitButton.interactable = false;
            rouletteUI.SpinRouletteWheel();
            rouletteGameUIEventChannel.RaiseOnSpinClicked();
        }

        private void UpdateCurrentRewardsUI(RewardData rewardData)
        {
            currentRewardsUI.UpdateRewardElementUI(FindRewardDataType(rewardData.RewardId), rewardData.Amount);
        }

        private int FindRewardDataIndex(string rewardId)
        {
            var RouletteElements = rouletteGameWrapper.RouletteData[currentRewardLevel - 1].RouletteElement;

            for (int i = 0; i < RouletteElements.Length; i++)
            {
                if (RouletteElements[i].RewardId == rewardId)
                    return i;
            }

            return -1;
        }

        private RewardType FindRewardDataType(string rewardId)
        {
            var RouletteElements = rouletteGameWrapper.RouletteData[currentRewardLevel - 1].RouletteElement;

            for (int i = 0; i < RouletteElements.Length; i++)
            {
                if (RouletteElements[i].RewardId == rewardId)
                    return RouletteElements[i].RewardType;
            }

            return RewardType.None;
        }

        private int FindNextGoldAreaLevel(int rewardLevel)
        {
            int nextLevel = 0;
            for (int i = 0; i < rouletteGameWrapper.GoldAreas.Count; i++)
            {
                int area = rouletteGameWrapper.GoldAreas[i];
                if (rewardLevel <= area)
                {
                    nextLevel = area;
                    return nextLevel;
                }
            }
            return nextLevel;
        }

        private int FindNextSilverAreaLevel(int rewardLevel)
        {
            int nextLevel = 0;
            for (int i = 0; i < rouletteGameWrapper.SilverAreas.Count; i++)
            {
                int area = rouletteGameWrapper.SilverAreas[i];
                if (rewardLevel <= area)
                {
                    nextLevel = area;
                    return nextLevel;
                }
            }
            return nextLevel;
        }

        public void HideQuitButton()
        {
            quitButton.gameObject.SetActive(false);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class QuitWarningUI : MonoBehaviour
    {
        [SerializeField] private Button quitButton;
        [SerializeField] private Button backButton;

        [SerializeField] private GameObject quitWarningPopUp;
        [SerializeField] private TextMeshProUGUI withPunishmentText;
        [SerializeField] private TextMeshProUGUI withoutPunishmentText;

        private void OnEnable()
        {
            quitButton.onClick.AddListener(OnQuit);
            backButton.onClick.AddListener(HideQuitWarningPopUp);
        }

        private void OnDisable()
        {
            quitButton.onClick.RemoveListener(OnQuit);
            backButton.onClick.RemoveListener(HideQuitWarningPopUp);
        }

        public void ShowQuitWarningPopUp(bool withPunishment)
        {
            quitWarningPopUp.SetActive(true);
            withPunishmentText.gameObject.SetActive(withPunishment);
            withoutPunishmentText.gameObject.SetActive(!withPunishment);
        }

        public void HideQuitWarningPopUp()
        {
            quitWarningPopUp.SetActive(false);
        }

        public void OnQuit()
        {
            SceneManager.LoadScene(0);//Normally this should be in scene Management Service
        }
    }
}

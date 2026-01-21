using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
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
            
        }

        private void OnDisable()
        {
            
        }

        public void ShowQuitWarningPopUp(bool withPunishment)
        {
            quitWarningPopUp.SetActive(true);
            withPunishmentText.gameObject.SetActive(withPunishment);
            withoutPunishmentText.gameObject.SetActive(!withPunishment);
        }
    }
}

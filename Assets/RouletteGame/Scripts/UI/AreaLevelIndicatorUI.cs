using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace RouletteGame.UI
{
    public class AreaLevelIndicatorUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI goldAreaIndicatorText;
        [SerializeField] private TextMeshProUGUI silverAreaIndicatorText;

        private int lastGoldLevel;
        private int lastSilverLevel;

        public void UpdateGoldAreaIndicatorText(int goldArea)
        {
            if(goldArea >= lastGoldLevel)
            {
                lastGoldLevel = goldArea;
                goldAreaIndicatorText.text = goldArea.ToString();
            }

            if (goldArea == 0)
                goldAreaIndicatorText.text = string.Empty;
        }

        public void UpdateSilverAreaIndicatorText(int silverArea)
        {
            if (silverArea >= lastSilverLevel)
            {
                lastSilverLevel = silverArea;
                silverAreaIndicatorText.text = silverArea.ToString();
            }

            if (silverArea == 0)
                silverAreaIndicatorText.text = string.Empty;
        }
    }
}
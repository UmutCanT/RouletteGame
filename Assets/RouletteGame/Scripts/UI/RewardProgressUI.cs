using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

namespace RouletteGame.UI
{
    public class RewardProgressUI : MonoBehaviour
    {
        [SerializeField] private RewardLevelItemUI levelItemPrefab;
        [SerializeField] private Image currentLevelBGImage;
        [SerializeField] private List<RewardLevelItemUI> levelProgressItems;
        [SerializeField] private RectTransform content;


        public void Initialize(int totalLevel)
        {
            for (int i = 1; i <= totalLevel; i++)
            {
                var item = Instantiate(levelItemPrefab, content);
                item.UpdateLevelText(i);
                levelProgressItems.Add(item);
            }
        }
    }
}
using DG.Tweening;
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
        private const float CONTAINER_START_POSITON_X = 1450f;
        private const float MOVEMENT_DISTANCE = 100f;

        [SerializeField] private Image currentLevelBGImage;
        [SerializeField] private RectTransform container;
        [SerializeField] private List<RewardLevelItemUI> levelProgressItems;

        private readonly float moveDuration = 0.4f;
        private readonly Ease moveEase = Ease.OutCubic;

        private Tween moveTween;

        public void UpdateProgressBar(int currentLevel, Color textColor, Color bgColor)
        {
            int index = currentLevel - 1;
            float targetX =
            CONTAINER_START_POSITON_X -
            (index) * MOVEMENT_DISTANCE;

            moveTween?.Kill();

            moveTween = container
                .DOAnchorPosX(targetX, moveDuration)
                .SetEase(moveEase);

            if (index > 0)
                levelProgressItems[index - 1].BackToOriginalColor();

            levelProgressItems[index].UpdateLevelTextColor(textColor);

            currentLevelBGImage.color = bgColor;
        }
    }
}
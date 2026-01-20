using DG.Tweening;
using RouletteGame.Core;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace RouletteGame.UI
{
    public class RouletteUI : MonoBehaviour
    {

        [SerializeField] private Image rouletteSpinWheel;
        [SerializeField] private Image rouletteIndicator;
        [SerializeField] private List<RouletteElementUI> rouletteElementUIs;

        [Header("Spin Settings")]
        [SerializeField] private float initialSpinDuration = 2f;
        [SerializeField] private float spinSpeedUp = 3f;
        [SerializeField] private float finalSpinDuration = 3f;
        [SerializeField] private int minFullRotations = 3;
        [SerializeField] private int maxFullRotations = 5;

        private Tween spinTween;      
        private bool isSpinning = false;

        public void UpdateRouletteWheel(RouletteDataSO rouletteDataSO)
        {
            rouletteSpinWheel.sprite = rouletteDataSO.RouletteSprite;
            rouletteIndicator.sprite = rouletteDataSO.RouletteIndicator;

            for (int i = 0; i < rouletteElementUIs.Count; i++)
            {
                RouletteElementUI rouletteElement = rouletteElementUIs[i];
                RouletteElementDataSO elementData = rouletteDataSO.RouletteElement[i];
                rouletteElement.UpdateRouletteElementUI(elementData.RewardIcon, elementData.RewardAmount);
            }
        }

        public void SpinRouletteWheel()
        {
            if (isSpinning) return;

            isSpinning = true;

            spinTween?.Kill();

            // Yavaşça hızlanarak dönmeye başla
            Sequence spinSequence = DOTween.Sequence();

            // Phase 1: Slow Start
            spinSequence.Append(
                rouletteSpinWheel.transform.DORotate(new Vector3(0, 0, 360f), initialSpinDuration, RotateMode.LocalAxisAdd)
                .SetEase(Ease.InQuad)
            );

            // Phase 2: Infinite Loop
            spinSequence.Append(
                rouletteSpinWheel.transform.DORotate(new Vector3(0, 0, 360f), spinSpeedUp, RotateMode.LocalAxisAdd)
                .SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Incremental)
            );

            spinTween = spinSequence;
        }

        public async Task StopRouletteWheelSpin(int rewardIndex)
        {
            if (!isSpinning) return;

            await Task.Delay(2000);

            // Mevcut tweeni durdur
            spinTween?.Kill();

            // Her bir elemanın açı değeri
            float anglePerElement = 360f / rouletteElementUIs.Count;

            // Mevcut rotasyonu al (Z ekseninde)
            float currentZRotation = rouletteSpinWheel.transform.localEulerAngles.z;

            // Hedef açıyı hesapla (indicator üstte, saat yönünde dönüyor)
            float targetAngle = rewardIndex * anglePerElement;

            // Mevcut açıyı normalize et (0-360 arası)
            currentZRotation = currentZRotation % 360f;

            // Hedef açıya ulaşmak için gereken rotasyonu hesapla
            float angleDifference = targetAngle - currentZRotation;

            // Pozitif yönde en kısa yolu bul
            if (angleDifference < 0)
                angleDifference += 360f;

            // Tam tur sayısını rastgele belirle
            int fullRotations = Random.Range(minFullRotations, maxFullRotations + 1);

            // Toplam dönüş açısı = tam turlar + açı farkı
            float totalRotation = (fullRotations * 360f) + angleDifference;

            // 3 farklı durma stili arasından rastgele seç
            int stopStyle = Random.Range(0, 3);

            // Stil hesaplamaları için offset
            float styleOffset = anglePerElement * 0.15f;

            switch (stopStyle)
            {
                case 0: // Overshoot - azıcık aş, sonra hafif geri dön
                    Sequence overshootSeq = DOTween.Sequence();

                    // Hedefe git ve azıcık aş
                    overshootSeq.Append(
                        rouletteSpinWheel.transform.DORotate(
                            new Vector3(0, 0, totalRotation + styleOffset),
                            finalSpinDuration * 0.85f,
                            RotateMode.LocalAxisAdd
                        ).SetEase(Ease.OutCubic)
                    );

                    // Hafif geri dönüp tam yerine otur
                    overshootSeq.Append(
                        rouletteSpinWheel.transform.DORotate(
                            new Vector3(0, 0, -styleOffset),
                            finalSpinDuration * 0.15f,
                            RotateMode.LocalAxisAdd
                        ).SetEase(Ease.InOutSine)
                    );

                    spinTween = overshootSeq;
                    break;

                case 1: // Normal - tam yerine oturma
                    spinTween = rouletteSpinWheel.transform.DORotate(
                        new Vector3(0, 0, totalRotation),
                        finalSpinDuration,
                        RotateMode.LocalAxisAdd
                    ).SetEase(Ease.OutCubic);
                    break;

                case 2: // Undershoot - azıcık geride kal, sonra hafif ileri dön
                    Sequence undershootSeq = DOTween.Sequence();

                    // Hedefe git ama azıcık geride kal
                    undershootSeq.Append(
                        rouletteSpinWheel.transform.DORotate(
                            new Vector3(0, 0, totalRotation - styleOffset),
                            finalSpinDuration * 0.85f,
                            RotateMode.LocalAxisAdd
                        ).SetEase(Ease.OutCubic)
                    );

                    // Hafif ileri dönüp tam yerine otur
                    undershootSeq.Append(
                        rouletteSpinWheel.transform.DORotate(
                            new Vector3(0, 0, styleOffset),
                            finalSpinDuration * 0.15f,
                            RotateMode.LocalAxisAdd
                        ).SetEase(Ease.InOutSine)
                    );

                    spinTween = undershootSeq;
                    break;
            }

            // Animasyon bitene kadar bekle
            await spinTween.AsyncWaitForCompletion();

            isSpinning = false;
        }

        private void OnDestroy()
        {

            spinTween?.Kill();
        }
    }
}
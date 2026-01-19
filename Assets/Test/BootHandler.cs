using RouletteGame.Core;
using RouletteGame.Manager;
using RouletteGame.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    /// <summary>
    /// Module test boot
    /// </summary>
    public class BootHandler : MonoBehaviour
    {
        private RouletteGameManager gameManager;

        private void Awake()
        {
            ServiceLocator.Register<IRewardService>(null);
            gameManager = FindAnyObjectByType<RouletteGameManager>().GetComponent<RouletteGameManager>(); // Normally instantiate from prefab
        }

        // Start is called before the first frame update
        void Start()
        {
            gameManager.Initialize();
        }
    }
}
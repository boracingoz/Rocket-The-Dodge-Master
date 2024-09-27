using Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverpanel;

        private void Awake()
        {
            if (_gameOverpanel.activeSelf)
            {
                _gameOverpanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }


        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;
        }

        private void HandleOnGameOver()
        {
            if (!_gameOverpanel.activeSelf)
            {
                _gameOverpanel.SetActive(true);
            }
        }
    }
}



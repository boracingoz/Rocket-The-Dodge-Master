using Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager
{
    public class GameManager : SingletonThisObjects<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;

        private void Awake()
        {
            SingletonGameObject(this);
        }

        public void GameOver()
        {
            OnGameOver.Invoke();
        }

        public void MissionSucced()
        {
           OnMissionSucced?.Invoke();
           
        }

        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            SoundManager.Instance.StopSound(1);
           yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.Instance.PlaySound(2); 
        }

        public void LoadMenu()
        {
            StartCoroutine(LoadMenuAsync());
        }

        private IEnumerator LoadMenuAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }

        public void Exit()
        {
            Debug.Log("Exit the game...");
            Application.Quit();
        }
    }
}



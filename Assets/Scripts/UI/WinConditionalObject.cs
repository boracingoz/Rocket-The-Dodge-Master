using Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class WinConditionalObject : MonoBehaviour
    {
        [SerializeField] GameObject _winConPanel;

        private void Awake()
        {
            if (_winConPanel.activeSelf)
            {
                _winConPanel.SetActive(false);
            }

        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
        }
        private void HandleOnMissionSucced()
        {
            if (!_winConPanel.activeSelf)
            {
                _winConPanel.SetActive(true);
            }
        }
    }

}

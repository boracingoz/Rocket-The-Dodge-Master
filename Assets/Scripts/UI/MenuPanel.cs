using Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartBTN()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitBTN()
        {
            GameManager.Instance.Exit();
        }
    }

}


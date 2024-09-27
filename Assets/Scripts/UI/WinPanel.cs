using Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class WinPanel : MonoBehaviour
    {
       public  void NextChallangeBTN()
       {
            GameManager.Instance.LoadLevelScene(1);
       }

        public void RestartBTN()
        {
          GameManager.Instance.LoadLevelScene(0);
        }

        public void MainMenuBTN()
        {
            GameManager.Instance.LoadMenu();
        }
        
    }

}


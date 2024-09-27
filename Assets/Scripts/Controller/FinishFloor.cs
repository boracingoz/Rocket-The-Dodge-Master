using Manager;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controller
{
    public class FinishFloor : MonoBehaviour
    {
        [SerializeField] private GameObject _finishLights;
        [SerializeField] private GameObject _fireWorks;


        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null || !player.CanMove)
            {
                return;
            }
            if (other.GetContact(0).normal.y == -1)
            {
                _finishLights.gameObject.SetActive(true);
                _fireWorks.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                 GameManager.Instance.GameOver();

            }

        }
    }
}
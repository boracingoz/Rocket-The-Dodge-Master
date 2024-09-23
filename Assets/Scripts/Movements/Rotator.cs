using Controller;
using System.Collections;
using UnityEngine;

namespace Movements
{
    public class Rotator 
    {
        Rigidbody _rb;
        PlayerController _playerController;

        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
            _rb = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float dir)
        {
            if (dir == 0)
            {
                if (_rb.freezeRotation) 
                {
                    _rb.freezeRotation = false;
                }

                return;
            }

            if (!_rb.freezeRotation)
            {
                _rb.freezeRotation = true;
            }

            _playerController.transform.Rotate(Vector3.back * Time.deltaTime * dir * _playerController.TurnSpeed);   
           
        }

    }
}
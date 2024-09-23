using Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movements
{
    public class Mover 
    {
        private Rigidbody _rb;
        PlayerController _playerController;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rb = playerController.GetComponent<Rigidbody>();   
        }

        public void FixedTick()
        {
            _rb.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);
        }
    }
}



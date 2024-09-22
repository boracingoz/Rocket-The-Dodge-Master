using Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;

        private Rigidbody _rb;
        DefaultInput _input;
        bool _isForceUp;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _input = new DefaultInput();
        }

        private void Update()
        {

            if (_input.isForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _rb.AddForce(Vector3.up * Time.deltaTime * _force);
            }
        }
    }
}


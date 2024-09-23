using Inputs;
using Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float turnSpeed = 10f;
        [SerializeField] float _force = 15f;

        private DefaultInput _input;
        private bool _isForceUp;

        private Mover _mover;
        private float _leftRight;
        private Rotator _rotator;

        public float TurnSpeed => turnSpeed;
        public float Force => _force;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
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

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
            }

            _rotator.FixedTick(_leftRight);
        }
    }
}


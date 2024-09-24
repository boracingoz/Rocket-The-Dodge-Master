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
        private bool _canForceup;

        private Mover _mover;
        private float _leftRight;
        private Rotator _rotator;
        private Fuel _fuel;

        public float TurnSpeed => turnSpeed;
        public float Force => _force;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();   
        }

        private void Update()
        {
            if (_input.isForceUp && !_fuel.IsEmpty)
            {
                _canForceup = true;
            }
            else
            {
                _canForceup = false;
                _fuel.FuelIncrease(0.01f);
            }

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            if (_canForceup)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }

            _rotator.FixedTick(_leftRight);
        }
    }
}


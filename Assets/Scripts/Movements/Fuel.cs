using Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float _maxFuel= 100;
        [SerializeField] float _curFuel;
        [SerializeField] ParticleSystem _particle;

        public bool IsEmpty => _curFuel < 1f;
        public float CurrentFuel => _curFuel / _maxFuel;

        private void Awake()
        {
            _curFuel = _maxFuel;
        }

        public void FuelIncrease(float increase)
        {
            _curFuel += increase;
            _curFuel = Mathf.Min( _curFuel, _maxFuel);

            if (_particle.isPlaying)
            {
                _particle.Stop();
            }

            SoundManager.Instance.StopSound(0);
        }

        public void FuelDecrease(float decrease)
        {
            _curFuel -= decrease;
            _curFuel = Mathf.Max(_curFuel, 0f);

            if (_particle.isStopped)
            { 
                _particle.Play();
            }

            SoundManager.Instance.PlaySound(0);
        }
    }
}



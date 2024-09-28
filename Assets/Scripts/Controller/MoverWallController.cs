using System.Collections;
using UnityEngine;

namespace Controller
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed = 1f;

        private  float _factor;
        private Vector3 _startPos; // walls pos 
        const float FULL_CIRCLE = Mathf.PI * 2;

        private void Awake()
        {
            _startPos = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);

            _factor = Mathf.Abs(sinWave);

            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPos;

        }
    }
}
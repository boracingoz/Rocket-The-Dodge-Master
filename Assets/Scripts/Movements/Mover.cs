using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movements
{
    public class Mover 
    {
        private Rigidbody _rb;

        public Mover(Rigidbody rigidbody)
        {
            _rb = rigidbody;
        }

        public void FixedTick()
        {
            _rb.AddRelativeForce(Vector3.up * Time.deltaTime * 10f);
        }
    }
}



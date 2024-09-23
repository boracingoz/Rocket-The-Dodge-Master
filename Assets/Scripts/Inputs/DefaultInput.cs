using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Inputs
{
    public class DefaultInput 
    {
        DefaultAction _input;

        public bool isForceUp { get; private set; }
        public float LeftRight { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultAction();
            //anonim meth
            _input.Rocket.ForceUp.performed += context => isForceUp = context.ReadValueAsButton();
            _input.Rocket.LeftRight.performed += contex => LeftRight = contex.ReadValue<float>();

            _input.Enable();
        }
    }
}



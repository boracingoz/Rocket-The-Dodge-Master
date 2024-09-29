using Movements;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class FuelSlider : MonoBehaviour
    {
        private Slider _slider;
        private Fuel _fuel;

        private void Awake()
        {
          _slider = GetComponent<Slider>();  
          _fuel = FindObjectOfType<Fuel>();
        }

        // Update is called once per frame
        void Update()
        {
            _slider.value = _fuel.CurrentFuel;
        }
    }
}
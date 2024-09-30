using System;
using System.Collections;
using UnityEngine;
using Abstract;

namespace Manager
{
    public class SoundManager :SingletonThisObjects<SoundManager>
    {
        AudioSource[] _audioSource;

        private void Awake()
        {
            SingletonGameObject(this);

            _audioSource = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if (!_audioSource[index].isPlaying)
            {
                _audioSource[index].Play();
            }
        }

        public void StopSound(int index)
        {
            if (_audioSource[index].isPlaying)
            {
                _audioSource[index].Stop();
            }
        }
       
    }
}
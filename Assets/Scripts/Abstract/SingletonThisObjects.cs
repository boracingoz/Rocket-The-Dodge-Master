using Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Abstract
{
    public abstract class SingletonThisObjects<T> : MonoBehaviour
    {
        public static T Instance { get; private set; }

        protected void SingletonGameObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

    }

}


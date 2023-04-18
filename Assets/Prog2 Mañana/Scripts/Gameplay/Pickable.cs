using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Maniana
{
    public abstract class Pickable : MonoBehaviour
    {
        public void EVENT_Pick()
        {
            OnPick();
        }

        protected abstract void OnPick();
    }
}


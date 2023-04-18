using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Programacion2.Maniana
{
    public class PlayerSensor : MonoBehaviour
    {
        [SerializeField] UnityEvent EV_OnPlayerEnter;
        [SerializeField] UnityEvent EV_OnPlayerExit;

        private void OnTriggerEnter(Collider other)
        {
            if (IsPlayer(other))
            {
                EV_OnPlayerEnter.Invoke();
            }
            
        }
        private void OnTriggerExit(Collider other)
        {
            if (IsPlayer(other))
            {
                EV_OnPlayerExit.Invoke();
            }
            
        }

        bool IsPlayer(Collider col)
        {
            Character c = col.GetComponent<Character>();
            if (c == GameManager.instance.GetCharacter())
            {
                return true;
            }
            return false;
        }
    }
}
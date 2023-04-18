using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Programacion2.Noche
{
    //responsabilidad UNICA, de detectar al player
    public class PlayerSensor : MonoBehaviour
    {
        [SerializeField] UnityEvent UE_OnTriggerEnter; 
        [SerializeField] UnityEvent UE_OnTriggerExit;

        private void OnTriggerEnter(Collider other)
        {
            MyCharacter c = other.GetComponent<MyCharacter>();

            if (c != null)
            {
                UE_OnTriggerEnter.Invoke();
            }
        }
        private void OnTriggerExit(Collider other)
        {
            MyCharacter c = other.GetComponent<MyCharacter>();

            if (c != null)
            {
                UE_OnTriggerExit.Invoke();
            }
        }
    }
}

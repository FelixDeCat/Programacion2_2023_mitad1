using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Maniana
{
    public class MyCamera : MonoBehaviour
    {
        [SerializeField] Transform target; //el char
        Vector3 offset;
        [SerializeField] Vector3 offsetManual; // un offset manual para editar en play
        Vector3 final;

        [SerializeField] float lerpspeed = 1f;
        private void Start()
        {
            target = GameManager.CharTransform;
            target = GameManager.instance.GetCharacter().transform;

            //obtengo esa diferencia entre el target y mi primer posicion
            offset = transform.position - target.position;
        }
        private void LateUpdate()
        {
            // obtengo la posicion deseada
            final = target.transform.position + offset + offsetManual;

            //lerpeo entre mi posicion y la posicion deseada
            transform.position = Vector3.Lerp(transform.position, final, Time.deltaTime * lerpspeed);
        }

    }

}

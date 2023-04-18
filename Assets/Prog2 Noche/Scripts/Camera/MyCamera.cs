using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Noche
{
    public class MyCamera : MonoBehaviour
    {
        [SerializeField] Transform target;
        Vector3 offset;
        Vector3 final;
        [SerializeField] float smoothSpeed = 1f;

        void Start()
        {
            offset = transform.position - target.position;
        }

        void LateUpdate() //en el pipeline, se ejecuta despues del Update normal
        {
            final = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, final, Time.deltaTime * smoothSpeed);
        }
    }

}

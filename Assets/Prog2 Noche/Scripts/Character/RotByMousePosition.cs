using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Noche
{
    public class RotByMousePosition : MonoBehaviour
    {
        [SerializeField] Transform root;
        [SerializeField] LayerMask mask; //layer floor
        [SerializeField] float lookSpeed = 1f;

        void Update()
        {
            Vector2 mouseposition = Input.mousePosition; //posicion 2D del mouse en pantalla

            //convierte la posicion de pantalla 2D a un rayo 3D
            //este rayo, su origen es la camara misma
            Ray rayToWorld = Camera.main.ScreenPointToRay(mouseposition);

            //informacion de la colision
            RaycastHit hit;

            //el rayo fisico 100% real no fake
            Physics.Raycast(rayToWorld, out hit, float.MaxValue, mask);

            //punto de colision en el mundo
            Vector3 point = hit.point;

            //le digo que apunte a ese punto de colision
            //  root.forward = point;

            Vector3 dir = point - root.position;
            dir.y = 0;

            root.forward = Vector3.Slerp(root.forward, point, Time.deltaTime * lookSpeed);

        }
    }

}

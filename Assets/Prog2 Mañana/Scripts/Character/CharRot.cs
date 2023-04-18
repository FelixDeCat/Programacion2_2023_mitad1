using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Maniana
{
    public class CharRot : MonoBehaviour
    {
        Transform root;
        [SerializeField] LayerMask floor;
        [SerializeField] float rotSpeed = 5f;

        private void Awake()
        {
            root = this.GetComponent<Transform>();
        }

        private void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit info;

            Physics.Raycast(ray, out info, float.MaxValue, floor);

            Vector3 point = info.point;

            Vector3 dir = point - root.position;
            // dir.Normalize();
            dir.y = 0;

            root.forward = Vector3.Slerp(transform.forward, dir, Time.deltaTime * rotSpeed);

        }
    }

}

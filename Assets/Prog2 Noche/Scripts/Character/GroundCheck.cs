using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Noche
{

    public class GroundCheck : MonoBehaviour
    {
        [SerializeField] LayerMask ground;
        [SerializeField] float radius = 0.5f;

        bool isGrounded;

        public bool IsGrounded
        {
            get
            {
                return isGrounded;
            }
        }

        private void Update()
        {
            var colliders = Physics.OverlapSphere(transform.position, radius, ground);
            isGrounded = colliders.Length > 0;
        }


        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Noche
{
    public class Test : MonoBehaviour
    {
        //distance
        public Transform Boid;
        public Transform pos1;
        public Transform pos2;
        float distMin = 0.5f;
        int index = 0;

        //lerp
        public Transform Boid2;
        public Transform pos3;
        public Transform pos4;
        Vector3 pos_lerp;
        float timer = 0f;
        int index_lerp = 0;
        [SerializeField] float move_delay = 1f;

        [SerializeField] AnimationCurve curve;


        void Start()
        {
            pos_lerp = pos3.transform.position;
        }

        private void Update()
        {

            //LERP
            if (timer < move_delay)
            {
                timer = timer + 1 * Time.deltaTime;

                if (index_lerp == 0)
                {
                    Boid2.position = Vector3.Lerp(pos3.position, pos4.position, timer);
                }
                else
                {
                    Boid2.position = Vector3.Lerp(pos4.position, pos3.position, timer);
                }

            }
            else
            {
                timer = 0;
                if (index_lerp == 0) index_lerp = 1;
                else index_lerp = 0;
            }

            //MAGNITUDE
            if (index == 0)
            {
                Vector3 dir = pos2.position - Boid.transform.position;
                Boid.transform.position = Boid.transform.position + dir * Time.deltaTime;

                if (Vector3.Distance(Boid.position, pos2.position) < distMin)
                {
                    index = 1;
                }
            }
            else
            {
                Vector3 dir = pos1.position - Boid.transform.position;
                Boid.transform.position = Boid.transform.position + dir * Time.deltaTime;

                if (Vector3.Distance(Boid.position, pos1.position) < distMin)
                {
                    index = 0;
                }

            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.white;
            Gizmos.DrawLine(pos1.position, pos2.position);
            Gizmos.DrawLine(pos3.position, pos4.position);

            Gizmos.color = Color.black;
            Gizmos.DrawSphere(pos1.position, 0.1f);
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(pos2.position, 0.1f);

            Gizmos.color = Color.black;
            Gizmos.DrawSphere(pos3.position, 0.1f);
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(pos4.position, 0.1f);

        }
    }

}

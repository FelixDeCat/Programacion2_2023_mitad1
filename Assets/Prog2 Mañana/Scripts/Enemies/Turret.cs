using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Programacion2.Maniana
{
    public class Turret : MonoBehaviour
    {
        Transform target;
        Vector3 char_pos { get { return target.position; } }
        [SerializeField] Transform pivot;
        [SerializeField] float slerpSpeed;
        [SerializeField] Transform shootPoint;
        [SerializeField] Bullet model;

        [SerializeField] int damage = 20;
        float timer = 0;
        [SerializeField] float time_to_shoot = 1f;

        void Start()
        {
            target = GameManager.CharTransform;
        }

        void Update()
        {
            Vector3 dir = char_pos - pivot.position;
            dir.Normalize();
            dir.y = 0;
            pivot.transform.forward = Vector3.Slerp(pivot.forward, dir, slerpSpeed * Time.deltaTime);


            if (timer < time_to_shoot)
            {
                timer = timer + 1 * Time.deltaTime;
            }
            else
            {
                Shoot();
                timer = 0;
            }
        }

        void Shoot()
        {
            var bullet = GameObject.Instantiate(model);
            bullet.Move(shootPoint.position, shootPoint.forward, damage);
        }
    }

}


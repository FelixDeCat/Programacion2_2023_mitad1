using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Programacion2.Maniana;

public class Bullet : MonoBehaviour
{
    float speed = 5f;
    bool isMoving = false;
    float destroyTime = 1.5f;
    float timer = 0;
    int damage = 5;

    //private void Start()
    //{
    //    //Invoke("DestroyBullet", destroyTime); //te salva las papas, es solo para prototipar
    //}

    void DestroyBullet()
    {
        Destroy(this.gameObject); //en vez de usar esto, se lo devuelven al pool, reciclan
    }

    private void OnTriggerEnter(Collider other)
    {
        Character c = other.GetComponent<Character>();
        if (c != null)
        {
            c.TakeDamage(damage);
            DestroyBullet();
        }
    }

    public void Move(Vector3 pos, Vector3 dir, int _dmg = 5)
    {
        transform.position = pos;
        transform.forward = dir;
        isMoving = true;
        damage = _dmg;
    }

    private void Update()
    {
        if (!isMoving) return;

        if (timer < destroyTime)
        {
            timer = timer + 1 * Time.deltaTime;
        }
        else
        {
            DestroyBullet();
        }
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }
}

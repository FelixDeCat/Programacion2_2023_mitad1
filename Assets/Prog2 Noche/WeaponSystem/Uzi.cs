using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : WeaponBase
{
    public override void Shoot()
    {
        //shoot de uzi
    }

    float timer;
    private void Update()
    {
        if (timer < 5)
        {
            timer += Time.deltaTime;

            timer = timer + 1 * Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public WeaponBase[] weapons;
    int index = 0;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            weapons[index].Shoot();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            index = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Noche
{
    public class MedicPack : MonoBehaviour
    {
        public void EV_Heal()
        {
            GameManager.instance.character.Heal(20);
        }
    }
}


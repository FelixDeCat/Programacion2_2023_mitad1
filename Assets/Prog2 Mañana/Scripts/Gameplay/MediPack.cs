using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Maniana
{
    public class MediPack : Pickable
    {
        public int healQuantity = 20;

        protected override void OnPick()
        {
            GameManager.instance.GetCharacter().Heal(healQuantity);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Noche
{
    public class Button : MonoBehaviour
    {
        public Animator anim;

        public void EV_ANIM_OpenDoor()
        {
            anim.Play("Open");
        }

        public void EV_ANIM_CloseDoor()
        {
            anim.Play("Close");
        }
    }
}


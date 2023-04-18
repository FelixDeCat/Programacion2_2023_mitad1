using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Maniana
{
    public class AnimDoor : MonoBehaviour
    {
        public Animator anim;

        public void EVENT_Open()
        {
            anim.Play("Open");
        }
        public void EVENT_Close()
        {
            anim.Play("Close");
        }
    }
}


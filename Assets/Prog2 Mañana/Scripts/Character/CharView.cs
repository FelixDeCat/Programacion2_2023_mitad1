using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Maniana
{
    public class CharView : MonoBehaviour
    {
        Animator myAnim;

        [SerializeField] Transform weapon;

        private void Awake()
        {
            myAnim = GetComponentInChildren<Animator>();
        }

        public void IsRunning(bool running)
        {
            myAnim.SetBool("isRunning", running);
        }

        public void Horizontal(float h)
        {
            myAnim.SetFloat("horizontal", h);
        }
        public void Vertical(float v)
        {
            myAnim.SetFloat("vertical", v);
        }


        public void Grab()
        {
            myAnim.SetTrigger("grab");
        }

        public void GrabMoment()
        {
            weapon.gameObject.SetActive(true);
        }

        //si saben usar actions o delegados, y diccionarios
        //public void ANIMEV_EXE(string val)
        //{
        //    //desencriptamos con un diccionarion <string, Action>
        //}

    }

}
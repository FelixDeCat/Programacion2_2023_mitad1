using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Maniana
{
    public class CharAnimEvents : MonoBehaviour
    {
        public CharView view;
        public Character character;
        public void ANIMEV_GrabMoment()
        {
            view.GrabMoment();
        }

        public void ANIMEV_Launch()
        {
            character.ANIMEV_RealJump();
        }

        public void OnDie()
        {
            GameManager.ResetGame();
        }
    }
}


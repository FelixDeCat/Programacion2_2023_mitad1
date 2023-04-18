using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Noche
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public MyCharacter character;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}


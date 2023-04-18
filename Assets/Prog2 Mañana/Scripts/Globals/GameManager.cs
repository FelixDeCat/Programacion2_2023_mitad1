using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Maniana
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        private void Awake()
        {
            if (instance == null) //el rey no existe
            {
                instance = this;
            }
            else // el rey ya existe
            {
                Destroy(this.gameObject);
            }

            character = FindObjectOfType<Character>();
        }
        public Character GetCharacter() //0 player 1, 1 player 2
        {
            return character;
        }

        Character character;
        public Character Character
        {
            get
            {
                return character;
            }
        }
        public static Transform CharTransform
        {
            get
            {
                return instance.character.transform;
            }
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Programacion2.Maniana
{
    public class CharLife : MonoBehaviour
    {

        [SerializeField] int MaxLife = 100;
        [SerializeField] UnityEvent EV_OnDie;
        int life;
        public int Life
        {
            get
            {
                return life;
            }

            set
            {
                life = value;
                if (value <= 0)
                {
                    life = 0;
                    EV_OnDie.Invoke();
                }
                if (value > MaxLife)
                {
                    life = MaxLife;
                }

                Debug.Log((float)life / MaxLife);

                UI_LifeBar.instance.RefreshLifeBar((float)life / MaxLife);
            }
        }


        private void Start()
        {
            Life = MaxLife;

        }

        public void Resurrect()
        {
            Life = MaxLife;
        }
        public void TakeDamage(int dmg)
        {
            Debug.Log("Take damage");
            Life -= dmg;
        }
        public void Heal(int heal)
        {
            Life += heal;
        }
    }

}

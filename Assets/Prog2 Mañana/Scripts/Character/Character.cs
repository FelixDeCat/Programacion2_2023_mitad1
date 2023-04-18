using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Maniana
{
    public class Character : MonoBehaviour
    {
        Rigidbody rb;
        
        //sigue siendo privado pero lo veo en el editor
        [SerializeField] float speed = 100;

        public List<int> keys = new List<int>();

        internal bool HasKey(int code)
        {
            
            return keys.Contains(code); // ya tengo la llave
        }
        public void AddKey(int key)
        {
            keys.Add(key);
        }

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Start()
        {

        }

        public void Heal(int val)
        {
            print("Lo curamos: " + val);
        }

        void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(new Vector3(0,5,0), ForceMode.VelocityChange);
            }
        }

        float yfall;
        private void FixedUpdate()
        {
            yfall = rb.velocity.y;
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            
            //          vector * num  * normalizador de frames
            rb.velocity = move * speed * Time.deltaTime; //producto escalar

            rb.velocity = new Vector3(rb.velocity.x, yfall, rb.velocity.z);
        }
    }
}
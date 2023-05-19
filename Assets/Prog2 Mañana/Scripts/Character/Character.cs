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

        CharView view;

        GroundCheck groundCheck;
        [SerializeField] float jumpHeight = 5f;
        CharLife life;

        #region Keys
        public List<int> keys = new List<int>();
        internal bool HasKey(int code)
        {
            
            return keys.Contains(code); // ya tengo la llave
        }
        public void AddKey(int key)
        {
            keys.Add(key);
        }
        #endregion

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            view = GetComponent<CharView>();
            life = GetComponent<CharLife>();
            groundCheck = GetComponentInChildren<GroundCheck>();
        }

        void Start()
        {

        }

        public void Heal(int val)
        {
            life.Heal(val);
        }

        public void TakeDamage(int damage)
        {
            life.TakeDamage(damage);
        }

        public void UEV_OnDie()
        {
            print("Me mori");
        }

        void Update()
        {

            if (Input.GetButtonDown("Fire1"))
            {
                view.BeginAttack();
            }

            if (Input.GetButtonDown("Jump") && groundCheck.IsGrounded)
            {
                
                view.Anim_Jump();
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                view.Grab();
            }
        }

        public void ANIMEV_RealJump()
        {
            float yForce = Mathf.Sqrt(jumpHeight * -2 * Physics.gravity.y);
            rb.velocity = new Vector3(rb.velocity.x, yForce, rb.velocity.z);
            rb.AddForce(Vector3.up * Physics.gravity.y, ForceMode.Acceleration);
        }

        float yfall;
        private void FixedUpdate()
        {
            yfall = rb.velocity.y;
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            view.Vertical(Input.GetAxis("Vertical"));
            view.Horizontal(Input.GetAxis("Horizontal"));

            //          vector * num  * normalizador de frames
            rb.velocity = move * speed * Time.deltaTime; //producto escalar

            rb.velocity = new Vector3(rb.velocity.x, yfall, rb.velocity.z);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Programacion2.Noche
{
    public class MyCharacter : MonoBehaviour
    {

        [SerializeField] private Rigidbody myRig;
        [SerializeField] private float speed = 200;

        float fallY = 0;
        [SerializeField] float jumpforce = 20f;

        GroundCheck ground;

        private void Awake()
        {
            ground = GetComponentInChildren<GroundCheck>();
        }

        private void Update()
        {
            if (Input.GetButtonDown("Jump") && ground.IsGrounded)
            {
                myRig.AddForce(Vector3.up * jumpforce, ForceMode.VelocityChange); //1 solo frame
            }
        }

        void FixedUpdate()
        {
            fallY = myRig.velocity.y; //motor de fisicas sin modificar

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            myRig.velocity = move * Time.deltaTime * speed;

            myRig.velocity = new Vector3(myRig.velocity.x, fallY, myRig.velocity.z);
        }


        public void Heal(int life)
        {
            print("Lo cureee: " + life);
        }
    }

}

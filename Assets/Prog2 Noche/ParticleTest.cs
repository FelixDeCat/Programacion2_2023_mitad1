using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTest : MonoBehaviour
{
    ParticleSystem myPartSystem;
    void Start()
    {
        myPartSystem = GetComponent<ParticleSystem>();


        FindObjectOfType<CharacterController>(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myPartSystem.Play();
        }

        //if (IsStopped)
        //{
        //    print("se detuvo");
        //}
    }

    private void OnParticleSystemStopped()
    {
        print("Se detuvieron las particulas");
    }

    public bool IsStopped
    {
        get
        {
            return !myPartSystem.isEmitting;
        }
    }


}

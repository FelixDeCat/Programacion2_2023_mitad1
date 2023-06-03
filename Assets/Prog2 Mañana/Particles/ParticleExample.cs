using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleExample : MonoBehaviour
{
    [SerializeField] ParticleSystem myParticle;

    Renderer renderParticle;

    void Start()
    {
        ParticleSystem part = GameObject.Instantiate(myParticle);
    }

    private void OnParticleSystemStopped()
    {
        print("OnStop");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            myParticle.Play();
        }
    }
}

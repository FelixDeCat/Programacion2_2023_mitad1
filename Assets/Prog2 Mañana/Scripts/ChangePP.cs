using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
//using UnityEngine.Rendering.PostProcessing.Universal;

public class ChangePP : MonoBehaviour
{
    public PostProcessVolume volume;
    public Bloom bloom;

    void Start()
    {
        volume = GetComponent<PostProcessVolume>();

        //volume.TryGetComponent<Bloom>(out bloom);

        volume.profile.TryGetSettings<Bloom>(out bloom);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            bloom.intensity.value = 30;
        }
    }
}

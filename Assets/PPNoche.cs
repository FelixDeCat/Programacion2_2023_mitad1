using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PPNoche : MonoBehaviour
{
    PostProcessVolume volume;
    Bloom bloom;

    void Start()
    {
        volume = GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings<Bloom>(out bloom);

        bloom.intensity.value = 37;

    }
}

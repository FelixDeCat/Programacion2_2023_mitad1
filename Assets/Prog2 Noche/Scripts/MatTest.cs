using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatTest : MonoBehaviour
{
    Renderer render;
    public Texture myTexture;
    public Material matToCHange;
    Material first;
    bool flipflop;

    void Start()
    {
        render = GetComponent<Renderer>();

        //render.material.color = Color.black;

        // render.materials[0].SetColor("_Color", Color.black);

        first = render.material;

       // render.material.SetTexture("_MainTex", myTexture);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flipflop = !flipflop;

            if (flipflop)
            {
                render.material = matToCHange;
            }
            else
            {
                render.material = first;
            }
        }
    }
}

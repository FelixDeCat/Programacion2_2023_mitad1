using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterials : MonoBehaviour
{

    Renderer render;
    Material myMat;
    Material def;
    public Material mat_detective;

    void Start()
    {
        render = GetComponent<Renderer>();
        myMat = render.material;
        def = render.material;
    }

    bool flipflop = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            myMat.SetColor("_Color", Color.red);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            flipflop = !flipflop;
            if (flipflop)
            {
                render.material = mat_detective;
            }
            else
            {
                render.material = def;
            }

        }
    }
}

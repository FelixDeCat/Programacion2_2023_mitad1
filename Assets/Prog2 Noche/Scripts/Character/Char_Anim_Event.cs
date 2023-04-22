using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Anim_Event : MonoBehaviour
{
    [SerializeField] MyChar_View view;

    public void ANIMEV_RealKick_Begin()
    {
        view.RealKIckBegin();
    }
    public void ANIMEV_RealKick_End()
    {
        view.RealKIckEnd();
    }
}

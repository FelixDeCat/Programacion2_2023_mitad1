using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Programacion2.Noche;

public class Char_Anim_Event : MonoBehaviour
{
    [SerializeField] MyChar_View view;
    [SerializeField] MyCharacter character;

    public void ANIMEV_RealKick_Begin()
    {
        view.RealKIckBegin();
    }
    public void ANIMEV_RealKick_End()
    {
        view.RealKIckEnd();
    }

    public void ANIMEV_Launch()
    {
        character.RealJump();
    }
}

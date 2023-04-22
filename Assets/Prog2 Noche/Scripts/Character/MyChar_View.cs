using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChar_View : MonoBehaviour
{
    Animator myAnim;
    [SerializeField] ParticleSystem kickFX;

    [SerializeField] GameObject damageTrigger;

    private void Awake()
    {
        myAnim = GetComponentInChildren<Animator>();
    }

    public void SetHorizontal(float horiz)
    {
        myAnim.SetFloat("horizontal", horiz);
    }
    public void SetVertical(float vert)
    {
        myAnim.SetFloat("vertical", vert);
    }

    public void Kick()
    {
        myAnim.SetTrigger("kick");
        
    }
    public void RealKIckBegin()
    {
        damageTrigger.SetActive(true);
        kickFX.Play();
    }
    public void RealKIckEnd()
    {
        damageTrigger.SetActive(false);
    }

}

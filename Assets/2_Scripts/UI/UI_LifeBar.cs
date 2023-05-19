using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_LifeBar : MonoBehaviour
{
    public static UI_LifeBar instance;
    [SerializeField] Image img;
    private void Awake()
    {
        instance = this;
    }

    public void RefreshLifeBar(float _amount)
    {
        img.fillAmount = _amount;
    }
}

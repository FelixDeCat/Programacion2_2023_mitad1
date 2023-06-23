using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class UI_Item : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] Image item;
    [SerializeField] Image rarity;
    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI quant;

    public void SetValues(Sprite _item, Sprite _rarity, string _title, string _quant)
    {
        item.sprite = _item;
        rarity.sprite = _rarity;
        title.text = _title;
        quant.text = _quant;
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("le hice click al " + title.text);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_Inventory : MonoBehaviour
{
    public static UI_Inventory instance;
    public Transform parentGrid;
    [SerializeField] UI_Item model;

    [SerializeField] Sprite rarity;

    List<UI_Item> items = new List<UI_Item>();

    private void Awake()
    {
        instance = this;
    }

    public void Refresh(List<Slot> slots)
    {
        for (int i = 0; i < items.Count; i++)
        {
            Destroy(items[i].gameObject);
        }
        items.Clear();

        for (int i = 0; i < slots.Count; i++)
        {
            UI_Item current = GameObject.Instantiate(model, parentGrid);
            current.SetValues(slots[i].item.image, rarity, slots[i].item.name, slots[i].quant.ToString());
            items.Add(current);
        }
    }

    
}

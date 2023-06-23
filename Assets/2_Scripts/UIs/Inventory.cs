using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Slot> slots = new List<Slot>();
    public int Max;

    public Item itemToAdd;

    void Start()
    {
        Add(itemToAdd);
        Add(itemToAdd);
    }

    public bool Add(Item item)
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].item.Equals(item))
            {
                slots[i].quant++;
                UI_Inventory.instance.Refresh(slots);
                return true;
            }
        }

        if (slots.Count >= Max) return false ;

        Slot slot = new Slot();
        slot.item = item;
        slot.quant = 1;

        slots.Add(slot);

        UI_Inventory.instance.Refresh(slots);

        return true;

    }
}

public class Slot
{
    public Item item;
    public int quant;
}

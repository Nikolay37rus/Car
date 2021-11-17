﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryModel : IInventoryModel
{
    private readonly List<IItem> _items = new List<IItem>();


    public IReadOnlyList<IItem> GetEquippedItem()
    {
        return _items;
    }

    public void EquipItem(IItem item)
    {
        if (_items.Contains(item))
            return;


        _items.Add(item);
    }

    public void UnEquipItem(IItem item)
    {
        if (!_items.Contains(item))
            return;

        _items.Remove(item);

    }
}

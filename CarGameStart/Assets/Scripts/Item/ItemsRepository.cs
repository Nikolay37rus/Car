﻿using System.Collections.Generic;


public class ItemsRepository : BaseController, IItemsRepository
{
    public IReadOnlyDictionary<int, IItem> Items => _itemsMapById;


     private Dictionary<int, IItem> _itemsMapById = new Dictionary<int, IItem>();   

    public ItemsRepository(List<ItemConfig> upgradeItemConfigs)
    {
        PopulateItems(upgradeItemConfigs);
    }

    private void PopulateItems(List<ItemConfig> upgradeItemConfigs)
    {
        foreach(var config in upgradeItemConfigs)
        {
            if (_itemsMapById.ContainsKey(config.Id))
                continue;

            _itemsMapById.Add(config.Id, CreateItem(config));
        }

        
    }
     private IItem CreateItem(ItemConfig config)
    {
        return new Item
        {
            Id = config.Id,
            ItemInfo = new ItemInfo { Title = config.Title }

        };
    }

    protected override void OnDispose()
    {
        _itemsMapById.Clear();
    }
}

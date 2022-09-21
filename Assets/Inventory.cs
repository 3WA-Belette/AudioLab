using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contains a list of item that the player own
/// </summary>
public class Inventory : MonoBehaviour
{
    /// <summary>
    /// Our bag
    /// </summary>
    [SerializeField] List<ItemSO> _item;

    internal void AddItem(ItemSO itemDroppedSO)
    {
        _item.Add(itemDroppedSO);

        ItemUI i = Instantiate(_itemUI, _itemUIRoot);
        i.SetItem(itemDroppedSO);
    }

    /// <summary>
    /// Prefab for one item
    /// </summary>
    [SerializeField] ItemUI _itemUI;
    /// <summary>
    /// Where the UI prefab should be instantiate
    /// </summary>
    [SerializeField] Transform _itemUIRoot;

    private void Start()
    {

        foreach(ItemSO item in _item)
        {
            ItemUI i = Instantiate(_itemUI, _itemUIRoot);
            i.SetItem(item);
        }

        //foreach(ItemSO el in _item)
        //{
        //    if(el is WeaponSO)
        //    {
        //        WeaponSO weapon = (WeaponSO)el;
        //
        //        WeaponSO weapon2 = el as WeaponSO;
        //
        //    }
        //}
    }


}

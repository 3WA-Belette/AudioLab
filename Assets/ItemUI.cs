using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] Image _itemSprite;
    [SerializeField] TextMeshProUGUI _itemName;

    internal void SetItem(ItemSO item)
    {
        _itemSprite.sprite = item.Sprite;
        _itemName.text = item.Name;
    }
}

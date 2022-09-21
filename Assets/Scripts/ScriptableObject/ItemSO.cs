using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSO : ScriptableObject
{
    [Header("ItemSO")]
    [SerializeField] int _price;
    [SerializeField] string _name;
    [SerializeField] float _weight;
    [SerializeField] Sprite _sprite;

    public int Price { get => _price; }
    public string Name { get => _name; }
    public float Weight { get => _weight; }
    public Sprite Sprite { get => _sprite; }

}
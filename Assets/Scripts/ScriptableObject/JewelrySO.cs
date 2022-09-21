using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="MesSO/Items/JewelrySO")]
public class JewelrySO : ItemSO
{
    [Header("JewelrySO")]
    [SerializeField] int _resellPrice;

    public int ResellPrice { get => _resellPrice; }
}

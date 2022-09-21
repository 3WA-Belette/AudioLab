using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="MesSO/Items/ConsumableSO")]
public class ConsumableSO : ItemSO
{
    [Header("ConsumableSO")]
    [SerializeField] int _regen;

    public int Regen { get => _regen;}
}

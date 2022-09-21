using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="MesSO/Items/WeaponSO")]
public class WeaponSO : ItemSO
{
    [Header("WeaponSO")]
    [SerializeField] int _attack;
    [SerializeField] int _defense;
    [SerializeField] int _speed;

    public int Attack { get => _attack;}
    public int Defense { get => _defense;}
    public int Speed { get => _speed;}
}

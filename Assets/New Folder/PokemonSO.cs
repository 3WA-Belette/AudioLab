using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[CreateAssetMenu(menuName = "MonScriptableObject")]
public class PokemonSO : ScriptableObject
{

#if false
#region InternalTypes
    [Serializable]
    public class PokemonStat
    {
        [SerializeField] int _level;
        [SerializeField] int _maxHealth;
        [SerializeField] int _attack;
        [SerializeField] int _defense;
        [SerializeField] float _vitesse;

        public int Level { get => _level; }
        public int MaxHealth { get => _maxHealth; }
        public int Attack { get => _attack; }
        public int Defense { get => _defense; }
        public float Vitesse { get => _vitesse; }
    }
    [SerializeField] List<PokemonStat> _stats;
    public PokemonStat GetStatByLevel(int level) => _stats.First(i => i.Level == level);
#endregion
#endif

    [SerializeField] string _name;
    [SerializeField] int _price;
    [SerializeField] int _weight;




}

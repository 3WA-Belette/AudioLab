using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Character : MonoBehaviour
{
    [SerializeField] PokemonSO _configuration;
    [SerializeField] PlayerReferenceSO _reference;

    int _currentHealth;
    int _deltaAttack;

    private void Start()
    {
        //_currentHealth = _configuration.MaxHealth;

        _deltaAttack = 10;

        _reference.SetPlayer(this);

    }


    public void AttackCharacter(Character enemy)
    {
        //var currentAttack = _configuration.Attack + _deltaAttack;

    }

}

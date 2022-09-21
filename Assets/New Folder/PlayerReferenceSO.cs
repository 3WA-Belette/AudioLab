using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="PlayerReference")]
public class PlayerReferenceSO : ScriptableObject
{

    Character _currentMainPlayer;

    public Character CurrentMainPlayer { get => _currentMainPlayer; }


    public void SetPlayer(Character c)
    {
        _currentMainPlayer = c;
    }

}

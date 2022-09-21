using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] PlayerReferenceSO _playerReference;


    private void Start()
    {

        var target = _playerReference.CurrentMainPlayer;


    }

}

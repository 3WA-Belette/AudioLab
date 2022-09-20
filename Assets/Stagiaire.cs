using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stagiaire: MonoBehaviour
{
    [SerializeField] TMP _tmp;

    private void Start()
    {
        _tmp.OnHealthChanged += _tmp_OnHealthChanged;

        //_tmp._health = -12;
        //_tmp.SetHealth(-12);
        //_tmp.Health = -12;
        //Debug.Log(_tmp.Health);
    }

    private void _tmp_OnHealthChanged(int arg0, int a)
    {
        throw new System.NotImplementedException();
    }

    private void OnDestroy()
    {

    }

}

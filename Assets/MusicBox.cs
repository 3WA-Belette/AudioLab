using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MusicBox : MonoBehaviour, IUsable
{
    [SerializeField] AudioSource _source;
    [SerializeField] UnityEvent _onBoublou;

    public event UnityAction OnBoubou;

    public string GetName() => "MusicBox";

    public void Use()
    {
        _source.Play();
    }

}

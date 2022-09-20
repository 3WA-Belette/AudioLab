using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MusicBox : MonoBehaviour, IUsable
{
    [SerializeField] string _sourdineName;
    [SerializeField, Range(0, 22000)] float _sourdineMin;
    [SerializeField, Range(0, 22000)] float _sourdineMax;
    [SerializeField] AudioMixer _mixer;
    [SerializeField] Animator _animator;

    bool _isOpen;

    private void Reset()
    {
        _sourdineName = "Sourdine";
        _sourdineMin = 600f;
        _sourdineMax = 22000f;

    }

    void Start()
    {
        _isOpen = false;
    }

    public string GetName() => "NightClub";


    //{
    //    return "NightClub";
    //}
    
    public void Use()
    {
        if(_isOpen)
        {
            _isOpen = false;
            _mixer.SetFloat(_sourdineName, _sourdineMin);
            _animator.SetTrigger("Close");
        }
        else
        {
            _isOpen = true;
            _mixer.SetFloat(_sourdineName, _sourdineMax);
            _animator.SetTrigger("Open");
        }
    }

}

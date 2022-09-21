using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="AnimatorSO")]
public class AnimatorSO : ScriptableObject
{
    [SerializeField] string _healthParamName;
    [SerializeField] string _SpeedParamName;
    [SerializeField] string _IsDeadParamName;

    public void SetHealthInAnimator(Animator a, int healthValue)
    {
        a.SetInteger(_healthParamName, healthValue);
    }



}

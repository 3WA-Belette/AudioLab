using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TMP : MonoBehaviour
{
    [SerializeField] UnityEvent _onBlabla;

    [SerializeField] int _maxHealth;

    public event UnityAction OnBlabla;
    public event UnityAction<int, int> OnHealthChanged;

    public int Age { get; private set; }


    int _health;
    public int Health
    {
        get => _health;
        private set
        {
            _health = Mathf.Clamp(value, 0, _maxHealth);
        }
    }

    public void LaunchCoucou()
    {
        int age = 12;

        Health = -12;

        if (OnBlabla != null)
        {
            OnBlabla.Invoke();
        }


        OnBlabla?.Invoke();
        _onBlabla?.Invoke();

        OnHealthChanged?.Invoke(_health, 12);
    }

#region ValeurRef
    void Start()
    {

        // int
        int maVariable = 42;
        Debug.Log($"[INT] PRE maVariable {maVariable}");
        PassageTypeValeur(ref maVariable);
        Debug.Log($"[INT] POST maVariable {maVariable}");

        // string
        string maVariable2 = "Hello World !";
        Debug.Log($"[STRING] PRE maVariable2 {maVariable2}");
        PassageTypeReference(ref maVariable2);
        Debug.Log($"[STRING] POST maVariable {maVariable2}");

        // Vector3
        Vector3 maVariable3 = Vector3.zero;
        Debug.Log($"[V3] PRE maVariable {maVariable3}");
        PassageVector3(maVariable3);
        Debug.Log($"[V3] POST maVariable {maVariable3}");

        // SpriteRenderer
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log($"[SR] PRE maVariable {spriteRenderer.color}");
        PassageSpriteRenderer(spriteRenderer);
        Debug.Log($"[SR] POST maVariable {spriteRenderer.color}");
    }

    void PassageTypeValeur(ref int monParam)
    {
        monParam = 3712;
    }

    void PassageTypeReference(ref string monParam)
    {
        monParam = "Ah bah non";
    }

    void PassageVector3(Vector3 monParam)
    {
        monParam = new Vector3(1, 2, 3);
    }

    void PassageSpriteRenderer(SpriteRenderer monParam)
    {
        monParam.color = Color.red;
    }

#endregion


}

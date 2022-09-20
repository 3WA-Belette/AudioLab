using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMP : MonoBehaviour
{
    void Start()
    {
        // int
        int maVariable = 42;
        Debug.Log($"[INT] PRE maVariable {maVariable}");
        PassageTypeValeur(maVariable);
        Debug.Log($"[INT] POST maVariable {maVariable}");

        // string
        string maVariable2 = "Hello World !";
        Debug.Log($"[STRING] PRE maVariable2 {maVariable2}");
        PassageTypeReference(maVariable2);
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

    void PassageTypeValeur(int monParam)
    {
        monParam = 3712;
    }

    void PassageTypeReference(string monParam)
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


}

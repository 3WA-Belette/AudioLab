using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour, IUsable
{
    public string GetName() => "Button";

    public void Use()
    {
        Debug.Log("Red : On m'a cliqué dessus !");
    }
}

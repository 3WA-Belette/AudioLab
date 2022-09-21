using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropped : MonoBehaviour
{
    [SerializeField] ItemSO _itemDropped;

    public ItemSO ItemDroppedSO { get => _itemDropped; }

}

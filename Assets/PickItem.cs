using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    [SerializeField] Inventory _inventory;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<ItemDropped>(out var item))
        {
            _inventory.AddItem(item.ItemDroppedSO);
            Destroy(item.gameObject);
        }


    }



}

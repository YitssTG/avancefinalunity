using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public Item[] items = new Item[10];

    public void AgregarItem(Item item)
    {
        for(int i = 0; i < items.Length; ++i)
        {
            if (items[i] == null)
            {
                items[i] = item;
                break;
            }
        }
    }
}

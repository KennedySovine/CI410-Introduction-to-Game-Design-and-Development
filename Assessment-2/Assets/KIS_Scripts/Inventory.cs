using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<GameObject> inven = new List<GameObject>();

    public void inventoryAdd(GameObject collect){
        inven.Add(collect);
    }

    public void inventoryRemove(GameObject collect){
        if (inven.Contains(collect)){
            inven.Remove(collect);
        }
    }

    public bool Check(GameObject collect){
        if (inven.Contains(collect)){
            return true;
        }
        return false;
    }
}

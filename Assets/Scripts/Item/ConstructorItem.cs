using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ConstructorItem
{
    public int itemId;
    public string nombreItem;

    public ConstructorItem(int id, string x){
        this.itemId = id;
        this.nombreItem = x;
    }

}

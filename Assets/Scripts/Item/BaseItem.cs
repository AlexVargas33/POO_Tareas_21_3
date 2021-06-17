using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : MonoBehaviour
{
    public ConstructorItem [] nuevoItem;

    void Awake() {
        nuevoItem = new ConstructorItem [2];
        nuevoItem[0] = new ConstructorItem(1, "Botiquin");
        nuevoItem[1] = new ConstructorItem(2, "Municion");

    }
}

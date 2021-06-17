using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemigo : MonoBehaviour
{
    //Arrey enemigos

    public ConstructorEnemigo [] nuevoEnemigo;

    void Awake() {
        nuevoEnemigo = new ConstructorEnemigo [3];
        nuevoEnemigo [0] = new ConstructorEnemigo(1, "Alien", 10, 10);
        nuevoEnemigo [1] = new ConstructorEnemigo(1, "Nave", 15, 10);
        nuevoEnemigo [2] = new ConstructorEnemigo(1, "Boss", 20, 10);
    }
}

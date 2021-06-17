using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugadores : MonoBehaviour
{
    //Cambio en experimentoarrey

    public ConstructorPlayer [] nuevoJugador;

    void Awake() {
        nuevoJugador = new ConstructorPlayer [1];
        nuevoJugador [0] = new ConstructorPlayer(1, "Sobreviviente",10, 10);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorEnemigo
{
    //Atributos
    public int enemigoId;
    public string nombreEnemigo;
    public float vidaEnemigo;
    public float velocidadEnemigo;
    private Transform posicionActual;
    private int daño;

    //Método Constructor
     public ConstructorEnemigo(int id, string n, float vida, float vel) {
        
        this.enemigoId = id;
        this.nombreEnemigo = n;
        this.vidaEnemigo = vida;
        this.velocidadEnemigo = vel;


    }
}

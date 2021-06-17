using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{

    public float daño;

    private void OnCollisionEnter(Collision other) {
        
        //Inicia la capsula
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<DañoJugador>().damage(daño);
        }
    }
    //Termina
}

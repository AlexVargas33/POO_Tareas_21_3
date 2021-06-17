using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionSanar : MonoBehaviour
{
    public float sanar;

    private void OnCollisionEnter(Collision other) {
        
        //Inicia la capsula
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<SanarJugador>().life(sanar);
        }
    }
    //Termina
}

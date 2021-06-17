using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoJugador : MonoBehaviour
{
    Player playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponentInParent<Player>();
    }

    public void damage()
    {
        playerData.vida -= 10;
    }

    public void damage(float daño)
    {
        playerData.vida -= 10;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanarJugador : MonoBehaviour
{
    Player playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponentInParent<Player>();
    }

    public void life()
    {
        playerData.vida += 10;
    }

    public void life(float sanar)
    {
        playerData.vida += 10;
    }
}

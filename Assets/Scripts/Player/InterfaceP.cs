using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceP : MonoBehaviour
{
    [Header ("Interfaces básicas")]

    public Text nombreTxT;
    public Text vidaTxT;

    [Header ("Interfaces TMPro")]

    public TMP_Text nombreTxTP;
    public TMP_Text vidaTxTP;

    Player playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponentInParent<Player>();
        StartCoroutine(AsignarDatos(1.5f));
    }

    // Update is called once per frame
    void Update()
    {
        if (nombreTxT != null)
        {
            nombreTxT.text = playerData.nombre;
        }

        if (vidaTxT != null)
        {
            vidaTxT.text = playerData.vida.ToString();
        }

        if (nombreTxTP != null)
        {
            nombreTxTP.text = playerData.nombre;
        }

        if (vidaTxTP != null)
        {
            vidaTxTP.text = playerData.vida.ToString();
        }
    }

    IEnumerator AsignarDatos(float waitTime)
    { 
        yield return new WaitForSeconds(waitTime);

        if (nombreTxT != null)
        {
            nombreTxT.text = playerData.nombre;
        }

        if (vidaTxT != null)
        {
            vidaTxT.text = playerData.vida.ToString();
        }

        if (nombreTxTP != null)
        {
            nombreTxTP.text = playerData.nombre;
        }

        if (vidaTxTP != null)
        {
            vidaTxTP.text = playerData.vida.ToString();
        }

    }
}

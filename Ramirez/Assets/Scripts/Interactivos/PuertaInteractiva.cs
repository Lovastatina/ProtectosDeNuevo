using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteractiva : ObjInteractivoGenerico
{
    private bool abierto = false;
    public override void ActivareAzione()
    {
        if (abierto == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            textoAzione = "Abrir la puerta";
        }

        else
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            textoAzione = "Cerrar la puerta";
        }
        abierto = !abierto;
    }
}

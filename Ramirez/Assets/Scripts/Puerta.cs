using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : ObjInteractivoGenerico
{
    private Animator miAnimador;
    private bool abierto = false;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    public override void ActivareAzione()
    {
        if (abierto == false)
        {
            miAnimador.SetTrigger("Abrire");
            textoAzione = "Abrir la puerta";
        }

        else
        {
            miAnimador.SetTrigger("Cerrar");
            textoAzione = "Cerrar la puerta";
        }
        abierto = !abierto;
    }


}

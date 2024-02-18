using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogataInt : ObjInteractivoGenerico
{
    public GameObject fuoco;
    private bool fuego = false;


    public override void ActivareAzione()
    {
        if (fuego == false)
        {
            fuoco.SetActive(true);
            textoAzione = "Apagar la fogota";
        }

        else
        {
            fuoco.SetActive(false);
            textoAzione = "Prender la fogata";
        }
        fuego = !fuego;
    }
}

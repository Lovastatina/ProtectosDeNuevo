using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampeInteractiva : ObjInteractivoGenerico
{
   public Light Lampe;
   private bool luz = false;
   public override void ActivareAzione()
    {
        if (luz == false)
        {
            Lampe.gameObject.SetActive(true);
            textoAzione = "Encender la luz";
        }

        else
        {
            Lampe.gameObject.SetActive(false);
            textoAzione = "Apagar la luz";
        }

        luz = !luz;
    }
}

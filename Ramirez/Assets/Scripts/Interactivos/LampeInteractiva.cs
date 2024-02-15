using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampeInteractiva : ObjInteractivoGenerico
{
    public Light Lampe;
   public override void ActivareAzione()
    {
        Lampe.gameObject.SetActive(true);
    }
}

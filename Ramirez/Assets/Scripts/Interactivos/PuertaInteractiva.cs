using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteractiva : ObjInteractivoGenerico
{
    public override void ActivareAzione()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}

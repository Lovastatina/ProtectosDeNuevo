using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaInt : ObjInteractivoGenerico
{

    public GameObject cos1;
    public GameObject cos2;
   
    private int cont = 1;

    
    public override void ActivareAzione()
    {
        
        if (cont == 1)
        {

            cos1.SetActive(true);
        }

        if (cont == 2)
        {

            cos2.SetActive(true);
            textoAzione = "Ya no queda nada más por desempacar.";
        }

        if (cont >= 3)
        {
            textoAzione = "Ya no queda nada más por desempacar.";
        }

        cont += 1;
    }

    // Update is called once per frame
    
}

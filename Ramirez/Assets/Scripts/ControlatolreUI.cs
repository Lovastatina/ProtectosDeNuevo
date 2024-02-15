using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlatolreUI : MonoBehaviour
{

    public static ControlatolreUI Instancia;

    public GameObject grupoPrompt;
    public Text etitquetaAzione;

    public void Start()
    {
        Instancia = this;
    }
    public void MostrarInteraccionObj(ObjInteractivoGenerico elObj)
    {
        if (elObj != null)
        {
            etitquetaAzione.text = elObj.textoAzione;
            grupoPrompt.SetActive(true);
        }
       
        else
        {
            grupoPrompt.SetActive(false);
        }
    }
}

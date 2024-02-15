using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjInteractivoGenerico : MonoBehaviour
{
    
    public string textoAzione;
    private bool playerEnContacto = false;

    public abstract void ActivareAzione();

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerEnContacto = true;
            ControlatolreUI.Instancia.MostrarInteraccionObj(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerEnContacto = false;
            ControlatolreUI.Instancia.MostrarInteraccionObj(null);
        }
    }

    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && playerEnContacto)
        {
            ActivareAzione();
            

        }
    }
}

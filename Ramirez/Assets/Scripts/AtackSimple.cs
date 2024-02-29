using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackSimple : MonoBehaviour
{
    private Animator miAnimador;
   
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            miAnimador.SetTrigger("Atack");
        }
    }
}

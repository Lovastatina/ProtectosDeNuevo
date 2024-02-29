using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacObj : MonoBehaviour
{
    private Animator miAnimador;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            miAnimador.SetTrigger("Inter");
        }
    }
}

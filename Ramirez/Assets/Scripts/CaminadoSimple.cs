using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoSimple : MonoBehaviour
{
    public int velCam  = 0 ;
    private Rigidbody miCorpo;
    private Animator miAnimador;
    // Start is called before the first frame update
    void Start()
    {
        miCorpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movH = Input.GetAxis("Vertical");
        
        if(movH > 0)
        {
            miCorpo.velocity = new Vector3(0, 0, velCam);
            miAnimador.SetBool("Cam", true);
        }

        else if (movH <= 0)
        {
            miCorpo.velocity = new Vector3(0, 0, 0);
            miAnimador.SetBool("Cam", false);
        }
    }
}

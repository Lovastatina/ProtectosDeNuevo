using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    private Animator elAnimador;
    private NavMeshAgent navegador;
    // Start is called before the first frame update
    void Start()
    {
        navegador = GetComponent<NavMeshAgent>();
        elAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform destino = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        if (destino != null && (Mathf.Abs((this.transform.position - destino.transform.position).magnitude) < 7f))
         {
            
             navegador.destination = destino.position;
             elAnimador.SetFloat("Vel", navegador.velocity.magnitude);

         }

        else
        {
            elAnimador.SetFloat("Vel", 0f );
        }




         if ((Mathf.Abs((this.transform.position - destino.transform.position).magnitude) < 1.5f))
         {
                
            elAnimador.SetBool("Atack", true);
           
         }

         else
         {
             elAnimador.SetBool("Atack", false);
         }

        
    }
}

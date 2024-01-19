using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CaminadoDireccional : MonoBehaviour
{
    public int velCam = 10;
    private Animator miAnimator;
    private Rigidbody miCorpo;
    // Start is called before the first frame update
    void Start()
    {
        miCorpo = GetComponent<Rigidbody>();
        miAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = miCorpo.velocity.y;
        float movV = Input.GetAxis("Vertical");
        float movH = Input.GetAxis("Horizontal");

        Vector3 direccion = new Vector3(movH, 0, movV);
        transform.forward = direccion;

        miAnimator.SetBool("Cam", direccion.magnitude > 0);

        if (direccion.magnitude > 0)
        {
             transform.forward = direccion;
        }
        miCorpo.velocity = transform.forward * direccion.magnitude * velCam + transform.up * velVert;

        if (Input.GetKeyDown(KeyCode.V))
        {
            miAnimator.SetTrigger("GNG");
        }
    }
}

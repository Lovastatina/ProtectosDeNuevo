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
    public float nonzo = 1f;
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

        Vector3 posI = new Vector3(0, 0, 0);
        Vector3 direccion = new Vector3(movH, 0, movV);
        miAnimator.SetBool("Cam", direccion.magnitude > 0);

        if (direccion.magnitude > 0)
        {
             transform.forward = Vector3.Slerp(posI,direccion, nonzo);
        }
        miCorpo.velocity = transform.forward * direccion.magnitude * velCam + transform.up * velVert;

        if (Input.GetKeyDown(KeyCode.V))
        {
            miAnimator.SetTrigger("GNG");
        }
    }
}

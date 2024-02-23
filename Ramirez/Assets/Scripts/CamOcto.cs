using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamOcto : MonoBehaviour
{
    public Transform coso;
    public float velocidadRot = 3;
    public float limiteRotY = 140f;
    private float rotacionVet = 0f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movHor = Input.GetAxis("Mouse X") * velocidadRot;
        float movVer = Input.GetAxis("Mouse Y") * velocidadRot;

        coso.Rotate(Vector3.up *movHor, Space.Self);

        rotacionVet += movVer;
        rotacionVet = Mathf.Clamp(rotacionVet, -limiteRotY, limiteRotY);
        coso.localEulerAngles = new Vector3(-rotacionVet, coso.localEulerAngles.y, 0f);
    }
}

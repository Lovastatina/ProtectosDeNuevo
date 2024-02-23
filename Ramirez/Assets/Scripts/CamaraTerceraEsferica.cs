using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTerceraEsferica : MonoBehaviour
{
    public float velRotacion = 1;
    public Transform pivote;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotHoriz = Input.GetAxis("Mouse X");
        pivote.Rotate(Vector3.up, rotHoriz * velRotacion);

        float rotVert = Input.GetAxis("Mouse Y");
        transform.Rotate(transform.right, rotVert, Space.World);
    }
}

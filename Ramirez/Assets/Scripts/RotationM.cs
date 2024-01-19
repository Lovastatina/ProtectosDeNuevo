using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RotationM : MonoBehaviour


{
    public float velRot = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
    
            float ejeRot = Input.GetAxis("Mouse X");
            transform.Rotate(transform.up * ejeRot * velRot, Space.Self);
        
    }
}

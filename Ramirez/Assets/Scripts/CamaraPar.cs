using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHell : MonoBehaviour
{
    public Transform personaje;


    void start()
    {


    }

    // Update is called once per frame
    void LateUpdate()
    {
        
            transform.position = new Vector3(personaje.transform.position.x - 3f , personaje.transform.position.y + 1f, personaje.transform.position.z );
           

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamIso : MonoBehaviour
{
   

    void start()
    {


    }

    // Update is called once per frame
    void LateUpdate()
    {
        float movHor = Input.GetAxis("Mouse X");
        float movVer = Input.GetAxis("Mouse Y");


        transform.position = new Vector3(transform.position.x + movHor ,transform.position.y,transform.position.z + movVer);


    }
}

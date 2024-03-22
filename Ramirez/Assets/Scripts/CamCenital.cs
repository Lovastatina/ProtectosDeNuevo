using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCenital : MonoBehaviour
{
    public Transform personajez;


    void start()
    {


    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = new Vector3(personajez.transform.position.x, personajez.transform.position.y + 8f, personajez.transform.position.z + 1f);


    }
}
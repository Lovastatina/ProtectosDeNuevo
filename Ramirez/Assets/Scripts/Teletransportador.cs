using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public GameObject areaActual;
    public GameObject areaDestino;

    private void OnDrawGizmos ()
    {
        Gizmos.DrawIcon(this.transform.position, "T_1_cursor_al");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject player = other.gameObject;
            player.SetActive(false);
            areaActual.SetActive(false);

            GameObject nuevaArea = Instantiate(areaDestino);
            nuevaArea.transform.position = Vector3.zero;

            Destroy(areaActual);
            PuntoSpawn punto = GameObject.FindFirstObjectByType<PuntoSpawn>();

            player.transform.position = punto.transform.position;
            player.SetActive(true);

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

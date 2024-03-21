using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class ColocadorNPC : MonoBehaviour
{
    private GameObject[] puntoSpaw;
    private void Awake()
    {
        print("Parsing");
        puntoSpaw = GameObject.FindGameObjectsWithTag("SpawnNPC");
        if (puntoSpaw != null)
        {
            print("Se encontraron" + puntoSpaw.Length + "puntos de spawn");
        }
    }

    private void OnDrawGizmos()
    {
        if (puntoSpaw == null)
        {
            return;
        }

        else {
            Gizmos.color = Color.yellow;
            foreach (GameObject punto in puntoSpaw)
            {
                Gizmos.DrawSphere(punto.transform.position, 1);
            }
        }
        
    }

    public void NPCGenerado(GameObject generador, GameObject npc)
    {
        print("Se generó un nuevo NPC" + npc.name);
        GameObject puntoAlt = puntoSpaw[Random.Range(0, puntoSpaw.Length)];
        npc.transform.position = puntoAlt.transform.position;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

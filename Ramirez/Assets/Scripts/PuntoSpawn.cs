using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(this.transform.position, "T_11_home_");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool bloquarMouse = true;
    // Start is called before the first frame update
    void Start()
    {
        if (bloquarMouse)
	{
	  Cursor.lockState = CursorLockMode.Locked;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCruz : MonoBehaviour
{
    public int velCam = 10;
    private Animator miAnimator;
    private Rigidbody miCorpo;
    // Start is called before the first frame update
    void Start()
    {
        miCorpo = GetComponent<Rigidbody>();
        miAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movV = Input.GetAxis("Vertical");
        float movH = Input.GetAxis("Horizontal");

        miAnimator.SetFloat("DESP_FRONTAL", movV);
        miAnimator.SetFloat("DESP_LATERAL", movH);

        miCorpo.velocity = (transform.forward * movV + transform.right * movH) * velCam;

    }
}

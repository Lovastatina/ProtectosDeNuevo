using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoInt : ObjInteractivoGenerico
{
    public AudioClip m1;
    public AudioClip m2;
    public AudioClip m3;

    private int num = 1;


    public override void ActivareAzione()
    {
        if (num == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(m1);


        }

        if (num == 2)
        {
            GetComponent<AudioSource>().PlayOneShot(m2);


        }

        if (num == 3)
        {
            GetComponent<AudioSource>().PlayOneShot(m3);

            num = num - 3;

        }



        num = num + 1;


    }
}

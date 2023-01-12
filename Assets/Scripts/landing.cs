using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class landing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alt, bat, av1, av2, lan;

    public Animator anim;
    float altq, batq, av1q, av2q, taxq;
    void Start()
    {
        anim = GetComponent<Animator>();
        altq = alt.transform.rotation.x;
        batq = bat.transform.rotation.x;
        av1q = av1.transform.rotation.x;
        av2q = av2.transform.rotation.x;
        taxq = lan.transform.rotation.x;
        Console.WriteLine(taxq.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        /*float altx = master_alt.transform.localEulerAngles.x;
        float batx = master_bat.transform.localEulerAngles.x;
        float av1x = avionic1.transform.localEulerAngles.x;
        float av2x = avionic2.transform.localEulerAngles.x;
        float taxx = taxi.transform.localEulerAngles.x;*/

        float altx = alt.transform.rotation.x;
        float batx = bat.transform.rotation.x;
        float av1x = av1.transform.rotation.x;
        float av2x = av2.transform.rotation.x;
        float taxx = lan.transform.rotation.x;

        if ((altx != altq || batx != batq) && av1x != av1q && av2x != av2q && taxx != taxq)
        {
            anim.SetBool("switon", true);
        }
        else
        {
            anim.SetBool("switon", false);
        }
    }
}

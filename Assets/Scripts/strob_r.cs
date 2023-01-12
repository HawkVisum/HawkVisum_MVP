using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strob_r : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alt, bat, av1, av2, strbr;
    public Animator anim;
    //Quaternion altq, batq, av1q, av2q, bcnq;
    float altq, batq, av1q, av2q, bcnq;
    void Start()
    {
        anim = GetComponent<Animator>();
        altq = alt.transform.rotation.x;
        batq = bat.transform.rotation.x;
        av1q = av1.transform.rotation.x;
        av2q = av2.transform.rotation.x;
        bcnq = strbr.transform.rotation.x;
    }

    // Update is called once per frame
    void Update()
    {

        float altx = alt.transform.rotation.x;
        float batx = bat.transform.rotation.x;
        float av1x = av1.transform.rotation.x;
        float av2x = av2.transform.rotation.x;
        float taxx = strbr.transform.rotation.x;

        if ((altx != altq || batx != batq) && av1x != av1q && av2x != av2q && taxx != bcnq)
        {
            anim.SetBool("switon", true);
        }
        else
        {
            anim.SetBool("switon", false);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_bcn_nav : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alt, bat, av1, av2, bcn;
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
        bcnq = bcn.transform.rotation.x;
    }

    // Update is called once per frame
    void Update()
    {

       /* float altx = Quaternion.Angle(alt.transform.rotation,altq);
        float batx = Quaternion.Angle(bat.transform.rotation,batq);
        float av1x = Quaternion.Angle(av1.transform.rotation,av1q);
        float av2x = Quaternion.Angle(av2.transform.rotation, av2q);
        float taxx = Quaternion.Angle(bcn.transform.rotation, bcnq);*/

        float altx = alt.transform.rotation.x;
        float batx = bat.transform.rotation.x;
        float av1x = av1.transform.rotation.x;
        float av2x = av2.transform.rotation.x;
        float taxx = bcn.transform.rotation.x;

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

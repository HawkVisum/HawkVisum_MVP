using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class flapleftscr : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject alt, bat;
    [SerializeField] private Transform flap10, flap20, flap40, handle;
    Quaternion flap0;
    private Vector3 v;
    int swit;
    float alti, bati, alty, baty;
    void Start()
    {
        swit = 0;
        v.y = 0; v.z = 0;
        flap0 = transform.rotation;
        alti = alt.transform.rotation.x;
        bati = bat.transform.rotation.x;
    }

    // Update is called once per frame
    void Update()
    {
        alty = alt.transform.rotation.x;
        baty = bat.transform.rotation.x;
        float y = handle.localPosition.y;
        if ((alty != alti || baty != bati))
        {
            float z = -0.0153f - y;
            var st = 0.5f * Time.deltaTime;
            
            if (z > 0.03)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, flap40.rotation, Time.deltaTime*0.15f);
            }
            else if (z > 0.028)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, flap20.rotation, Time.deltaTime*0.15f);
            }
            else if (z > 0.018)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, flap10.rotation, Time.deltaTime*0.15f);
            }
            else
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, flap0, Time.deltaTime*0.15f);
            }
        }
    }
}

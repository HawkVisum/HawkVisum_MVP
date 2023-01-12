using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class propmov_scr : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alt, bat, mixpull, thrott;
    [SerializeField] Transform Throttle_Start, Throttle_End, mixpullstart, mixpullend;
    public Transform magswit, magstart;
    public float alti, bati, alty, baty;
    public bool b;
    public float x;
    bool started;
    void Start()
    {
        alti = alt.transform.rotation.x; //will change after implementing start pos as script
        bati = bat.transform.rotation.x; //same
        b = false;
        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        alty = alt.transform.rotation.x;
        baty = bat.transform.rotation.x;
        float throttle_start = Throttle_Start.position.z;
        float throttle_end = Throttle_End.position.z;
        float mp_start = mixpullstart.position.z;
        float mp_end = mixpullend.position.z;
        float mx = Mathf.InverseLerp(mp_start, mp_end, mixpull.transform.position.z);
        float throty = Mathf.InverseLerp(throttle_start, throttle_end, thrott.transform.position.z);

        x = Math.Abs(Quaternion.Angle(magswit.rotation, magstart.rotation));
        b = x < 7.8;
        Vector3 v = new Vector3(0,1,0);
        
        if ((alty != alti || baty != bati) && b)
        {
            if ((mx != 0 || started) && throty != 0)
            {
                transform.Rotate(v * (200* mx + 16000 * throty) * Time.deltaTime);
                started = true;
            }
        }

        /*if ((mx != 0 || started) && throty != 0)
        {
            transform.Rotate(v * (90 * mx + 2700 * throty) * Time.deltaTime);
        }
        */
    }
}